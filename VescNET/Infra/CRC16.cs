using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Infra
{
    public class CRC16
    {
        private const ushort Polynomial = 0x8005;
        private ushort[] table = new ushort[256];

        public ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc;
        }

        public CRC16()
        {
            for (ushort i = 0; i < table.Length; ++i)
            {
                ushort value = 0;
                ushort temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ Polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
        }
    }
}
