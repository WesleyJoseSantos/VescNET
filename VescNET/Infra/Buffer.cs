using System;
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

        public void Init(byte[] data, int length = 0)
        {
            _data = data;
            idx = length;
        }

        public void AppendData<T>(T data, float scale = 0.0f, bool half = false)
        {
            if (data == null) throw new ArgumentNullException("data");

            if (typeof(T) == typeof(byte) || typeof(T) == typeof(bool) || data.GetType().IsEnum)
            {
                AppendByte(data);
                return;
            }

            if (typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
            {
                AppendWord(data);
                return;
            }

            if (typeof(T) == typeof(uint) || typeof(T) == typeof(int))
            {
                AppendDWord(data);
                return;
            }

            if (typeof(T) == typeof(float) && half == true)
            {
                AppendFloat16(data, scale); 
                return;
            }

            if (typeof(T) == typeof(float) && half == false)
            {
                AppendFloat32(data, scale);
                return;
            }

            if (typeof(T) == typeof(string))
            {
                AppendString(data as string);
                return;
            }

            if (data.GetType().IsArray)
            {
                AppendArray(data, scale, half);
                return;
            }

            throw new TypeAccessException();
        }

        public T GetData<T>(ref int idx, float scale = 0.0f, bool half = false)
        {
            if (typeof(T) == typeof(byte) || typeof(T) == typeof(bool) || typeof(T).IsEnum)
            {
                return (T)Convert.ChangeType(GetByte(ref idx), typeof(T));
            }

            if (typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
            {
                return (T)Convert.ChangeType(GetWord(ref idx), typeof(T));
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)Convert.ChangeType(GetUInt32(ref idx), typeof(T));
            }

            if (typeof(T) == typeof(int))
            {
                return (T)Convert.ChangeType(GetInt32(ref idx), typeof(T));
            }

            if (typeof(T) == typeof(float))
            {
                var value = half ? GetFloat16(ref idx, scale) : GetFloat32(ref idx, scale);
                return (T)Convert.ChangeType(value, typeof(T));
            }

            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(GetString(), typeof(T));
            }

            throw new TypeAccessException();
        }

        public T[] GetData<T>(ref int idx, uint size, float scale = 0.0f, bool half = false)
        {
            var data = GetArray<T>(ref idx, scale, half, size);
            return (T[])Convert.ChangeType(data, typeof(T[]));
        }

        public void Clear()
        {
            idx = 0;
            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] = 0;
            }
        }

        override public string ToString()
        {
            return BitConverter.ToString(_data);
        }

        private void AppendByte(dynamic data)
        {
            _data[idx++] = Convert.ToByte(data);
        }

        private byte GetByte(ref int idx)
        {
            return _data[idx++];
        }

        private void AppendWord(dynamic data)
        {
            var number = Convert.ToUInt32(data);
            _data[idx++] = (byte)(number >> 8);
            _data[idx++] = (byte)(number);
        }

        private int GetWord(ref int idx)
        {
            var number = _data[idx++] << 8;
            number += _data[idx++];
            return number;
        }

        private void AppendDWord(dynamic data)
        {
            var number = Convert.ToUInt32(data);
            _data[idx++] = (byte)(number >> 24);
            _data[idx++] = (byte)(number >> 16);
            _data[idx++] = (byte)(number >> 8);
            _data[idx++] = (byte)(number);
        }

        private int GetInt32(ref int idx)
        {
            int number = (_data[idx++] << 24);
            number += (_data[idx++] << 16);
            number += (_data[idx++] << 8);
            number += _data[idx++];
            return number;
        }

        private uint GetUInt32(ref int idx)
        {
            int number = (_data[idx++] << 24);
            number += (_data[idx++] << 16);
            number += (_data[idx++] << 8);
            number += _data[idx++];
            return (uint)number;
        }

        //private T GetDWord<T>(ref int idx)
        //{
        //    var number = (_data[idx++] << 24);
        //    number += (_data[idx++] << 16);
        //    number += (_data[idx++] << 8);
        //    number += _data[idx++];
        //    return (T)Convert.ChangeType(number, typeof(T));
        //}

        private void AppendFloat16(dynamic data, float scale)
        {
            if(scale == 0) data = Scale.ToInt(data);
            else data = data * scale;
            AppendWord(data);
        }

        private float GetFloat16(ref int idx, float scale)
        {
            var number = GetWord(ref idx);
            if (scale == 0) return Scale.ToFloat((uint)number);
            else return number / scale;
        }

        private void AppendFloat32(dynamic data, float scale)
        {
            if (scale == 0) data = Scale.ToInt(data);
            else data = data * scale;
            AppendDWord(data);
        }

        private float GetFloat32(ref int idx, float scale)
        {
            uint number = GetUInt32(ref idx);
            if (scale == 0) return Scale.ToFloat(number);
            else return number / scale;
        }

        private void AppendString(string text)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(text);
            for (int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
        }

        private string GetString()
        {
            var text = System.Text.Encoding.ASCII.GetString(_data);
            text = text.Split('\0')[0];
            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] = 0;
            }
            return text;
        }

        private void AppendArray(dynamic data, float scale, bool half)
        {
            for (int i = 0; i < data.Length; i++)
            {
                AppendData(data[i], scale, half);
            }
            return;
        }

        private dynamic GetArray<T>(ref int idx, float scale, bool half, uint size)
        {
            var array = new T[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = GetData<T>(ref idx, scale, half);
            }
            return array;
        }

    }
}
