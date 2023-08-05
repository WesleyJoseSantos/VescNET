﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Interfaces
{
    public interface IBuffer
    {
        byte[] Data { get; }
        void Clear();
        void AppendData<T>(T data);
        void AppendData<T>(T data, float scale);
        T GetData<T>(ref int index);
        T GetData<T>(ref int index, float scale);
    }
}