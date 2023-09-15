using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Infra
{
    public static class Scale
    {
        public static float ToFloat(uint res)
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

        public static uint ToInt(float number)
        {
            if (Math.Abs(number) < 1.5e-38)
            {
                number = 0.0f;
            }

            int e = 0;
            float sig = C.math.frexp(number, ref e);

            float sigAbs = (float)Math.Abs(sig);
            uint sigInt = 0;

            if (sigAbs >= 0.5)
            {
                sigInt = (uint)((sigAbs - 0.5f) * 2.0f * 8388608.0f);
                e += 126;
            }

            var res = (uint)(((e & 0xFF) << 23) | (sigInt & 0x7FFFFF));
            if (sig < 0)
            {
                res |= 1U << 31;
            }

            return res;
        }
    }
}
