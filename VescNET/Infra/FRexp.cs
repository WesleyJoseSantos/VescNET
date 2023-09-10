using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Infra
{
    public class FRexpResult
    {
        public int exponent;
        public double mantissa;
    }

    public static class FRexp
    {
        public static FRexpResult Calc(double value)
        {
            FRexpResult result = new FRexpResult();
            long bits = BitConverter.DoubleToInt64Bits(value);
            double realMant = 1.0;

            if (double.IsNaN(value) || value + value == value || double.IsInfinity(value))
            {
                result.exponent = 0;
                result.mantissa = value;
            }
            else
            {
                bool neg = (bits < 0);
                int exponent = (int)((bits >> 52) & 0x7FFL);
                long mantissa = bits & 0xFFFFFFFFFFFFFL;

                if (exponent == 0)
                {
                    exponent++;
                }
                else
                {
                    mantissa = mantissa | (1L << 52);
                }

                exponent -= 1075;
                realMant = mantissa;

                while (realMant > 1.0)
                {
                    mantissa >>= 1;
                    realMant /= 2.0;
                    exponent++;
                }

                if (neg)
                {
                    realMant = realMant * -1;
                }

                result.exponent = exponent;
                result.mantissa = realMant;
            }

            return result;
        }
    }
}
