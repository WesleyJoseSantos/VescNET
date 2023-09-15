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

        void Init(byte[] data, int lenght = 0);
        void Clear();
        void AppendData<T>(T data, float scale = 0.0f, bool half = false);
        T GetData<T>(ref int idx, float scale = 0.0f, bool half = false);
        T[] GetData<T>(ref int idx, uint size, float scale = 0.0f, bool half = false);
        string ToString();
    }
}
