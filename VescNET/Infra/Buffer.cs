using System;
using VescNET.Domain.Enums;
using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class Buffer : IBuffer
    {
        private int idx;

        private byte[] _data;

        public byte[] Data
        {
            get
            {
                var data = new byte[idx];
                Array.Copy(_data, data, idx);
                return data;
            }
        }

        public int Length => idx;

        public Buffer()
        {
            idx = 0;
        }

        public void Init(byte[] data)
        {
            _data = data;
        }

        public void AppendData<T>(T data)
        {
            if(data == null) throw new ArgumentNullException("data");

            if (typeof(T) == typeof(byte) ||
               typeof(T) == typeof(CommPacketId))
            {
                dynamic number = data;
                _data[idx++] = (byte)number;
                return;
            }

            if (typeof(T) == typeof(uint) || 
               typeof(T) == typeof(int) ||
               typeof(T) == typeof(float))
            {
                var number = Convert.ToInt32(data);
                AppendInt32(number);
                return;
            }

            throw new TypeAccessException();
        }

        public void AppendData<T>(T data, float scale)
        {
            if(data == null) throw new ArgumentNullException("data");
            var number = Convert.ToInt32(data);
            AppendData(number * scale);
        }

        public void Clear()
        {
            idx = 0;
        }

        public T GetData<T>(ref int index, float scale = 0)
        {
            if (typeof(T) == typeof(byte) || 
                
                typeof(T) == typeof(bool))
            {
                return (T)Convert.ChangeType(_data[index++], typeof(T));
            }

            if (typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
            {
                var number = _data[index++] << 8;
                number += _data[index++];
                return Scale<T>(number, scale);
            }

            if (typeof(T) == typeof(CommPacketId) ||
               typeof(T) == typeof(uint) ||
               typeof(T) == typeof(int) ||
               typeof(T) == typeof(float))
            {
                var number = _data[index++] << 24;
                number += _data[index++] << 16;
                number += _data[index++] << 8;
                number += _data[index++];
                return Scale<T>(number, scale);
            }

            throw new TypeAccessException();
        }

        public T GetHalf<T>(ref int index, float scale = 0)
        {
            // TODO: implement 16 bits negative floats
            if(typeof(T) == typeof(float))
            {
                var number = _data[index++] << 8;
                number += _data[index++];
                return Scale<T>(number, scale);
            }

            throw new TypeAccessException();
        }

        public T[] GetData<T>(ref int index, uint size, float scale = 0)
        {
            var data = new T[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = GetData<T>(ref index, scale);
            }
            return data;
        }

        public T[] GetHalf<T>(ref int index, uint size, float scale = 0)
        {
            var data = new T[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = GetHalf<T>(ref index, scale);
            }
            return data;
        }

        private void AppendInt32(int value)
        {
            _data[idx++] = (byte)(value >> 24);
            _data[idx++] = (byte)(value >> 16);
            _data[idx++] = (byte)(value >> 8);
            _data[idx++] = (byte)(value);
        }

        private T Scale<T>(int number, float scale = 0)
        {
            if(typeof(T) == typeof(uint))
            {
                var scaledNumber = (uint)number;
                return (T)Convert.ChangeType(scaledNumber, typeof(T));
            }
            else if (typeof(T) == typeof(float) && scale == 0)
            {
                var scaledNumber = FloatAutoScale((uint)number);
                return (T)Convert.ChangeType(scaledNumber, typeof(T));
            }
            else if (scale != 0)
            {
                var scaledNumber = Convert.ToSingle(number) / scale;
                return (T)Convert.ChangeType(scaledNumber, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(number, typeof(T));
            }
        }

        static float FloatAutoScale(uint res)
        {
            int e = (int)((res >> 23) & 0xFF);
            uint sig_i = res & 0x7FFFFF;
            bool neg = (res & (1 << 31)) != 0;

            float sig = 0.0f;
            if (e != 0 || sig_i != 0)
            {
                sig = (float)sig_i / (8388608.0f * 2.0f) + 0.5f;
                e -= 126;
            }

            if (neg)
            {
                sig = -sig;
            }

            return (float)(sig * Math.Pow(2, e));
        }
    }
}
