using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Interfaces
{
    public interface IBuffer
    {
        byte[] Data { get; }
        int Length {get; }

        void Init(byte[] data);
        void Clear();
        void AppendData<T>(T data, float scale = 0.0f, bool half = false);
        T GetData<T>(ref int idx, float scale = 0.0f, bool half = false);
        T[] GetData<T>(ref int idx, uint size, float scale = 0.0f, bool half = false);
        //T[] GetData<T>(ref int idx, uint size, float scale, bool half = false);
        //void AppendData<T>(T data, float scale = 1);
        //void AppendHalf<T>(T data, float scale = 1);
        //void AppendHalf<T>(T[] data, uint size, float scale = 1);
        //T GetData<T>(ref int index, float scale = 0);
        //T GetHalf<T>(ref int index, float scale = 0);
        //T[] GetData<T>(ref int index, uint size, float scale = 0);
        //T[] GetHalf<T>(ref int index, uint size, float scale = 0);
        string ToString();
    }
}
