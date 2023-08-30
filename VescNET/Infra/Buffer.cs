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

        public T GetData<T>(ref int index)
        {
            if (typeof(T) == typeof(byte))
            {
                index++;
                return (T)Convert.ChangeType(_data[index], typeof(T));
            }

            if (typeof(T) == typeof(bool) ||
               typeof(T) == typeof(CommPacketId) ||
               typeof(T) == typeof(uint) ||
               typeof(T) == typeof(int) ||
               typeof(T) == typeof(float))
            {
                var number = _data[index] << 24;
                number += _data[index + 1] << 16;
                number += _data[index + 2] << 8;
                number += _data[index + 3];
                index += 4;
                return (T)Convert.ChangeType(number, typeof(T));
            }

            throw new TypeAccessException();
        }

        public T GetData<T>(ref int index, float scale)
        {
            throw new NotImplementedException();
        }

        public T[] GetData<T>(ref int index, uint size)
        {
            var data = new T[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = GetData<T>(ref index);
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

    }
}
