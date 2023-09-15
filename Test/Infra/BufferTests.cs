using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using VescNET.Domain.Enums;
using VescNET.Infra;

namespace Test.Infra
{
    [TestClass]
    public class BufferTests
    {
        [TestMethod]
        public void TestInit()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            Assert.IsTrue(buffer.Length == 0);
        }

        [TestMethod]
        public void TestInitOverrideLenght()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data, 128);
            Assert.IsTrue(buffer.Length == 128);
        }

        [TestMethod]
        public void TestAppendByte()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            byte value = 0xFA;
            buffer.Init(data);
            buffer.AppendData(value);
            Assert.IsTrue(buffer.Length == 1);
            Assert.IsTrue(buffer.Data[0] == value);
        }

        [TestMethod]
        public void TestAppendBool()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            bool value = true;
            buffer.Init(data);
            buffer.AppendData(value);
            Assert.IsTrue(buffer.Length == 1);
            Assert.IsTrue(buffer.Data[0] == 0x01);
        }

        [TestMethod]
        public void TestAppendEnum()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            var value = AdcControlType.CurrentNoReverseBrakeAdc;
            buffer.Init(data);
            buffer.AppendData(value);
            Assert.IsTrue(buffer.Length == 1);
            Assert.IsTrue(buffer.Data[0] == 0x07);
        }

        [TestMethod]
        public void TestAppendUshort()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            ushort value = 0x1234;
            buffer.AppendData(value);
            Assert.IsTrue(buffer.Length == 2);
            Assert.IsTrue(buffer.Data[0] == 0x12);
            Assert.IsTrue(buffer.Data[1] == 0x34);
        }

        [TestMethod]
        public void TestAppendShort()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            short value = 0x1234;
            buffer.AppendData(value);
            Assert.IsTrue(buffer.Length == 2);
            Assert.IsTrue(buffer.Data[0] == 0x12);
            Assert.IsTrue(buffer.Data[1] == 0x34);
        }

        [TestMethod]
        public void TestAppendUint()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            uint value = 0x12345678;
            buffer.AppendData(value);
            Assert.IsTrue(buffer.Length == 4);
            Assert.IsTrue(buffer.Data[0] == 0x12);
            Assert.IsTrue(buffer.Data[1] == 0x34);
            Assert.IsTrue(buffer.Data[2] == 0x56);
            Assert.IsTrue(buffer.Data[3] == 0x78);
        }

        [TestMethod]
        public void TestAppendInt()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            int value = 0x12345678;
            buffer.AppendData(value);
            Assert.IsTrue(buffer.Length == 4);
            Assert.IsTrue(buffer.Data[0] == 0x12);
            Assert.IsTrue(buffer.Data[1] == 0x34);
            Assert.IsTrue(buffer.Data[2] == 0x56);
            Assert.IsTrue(buffer.Data[3] == 0x78);
        }

        [TestMethod]
        public void TestAppendFloat16()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            float value = 25.48F;
            uint expected = Scale.ToInt(value);
            buffer.AppendData(value, 0.0F, true);
            Assert.IsTrue(buffer.Length == 2);
            Assert.IsTrue(buffer.Data[0] == (byte)((expected >> 8) & 0xFF));
            Assert.IsTrue(buffer.Data[1] == (byte)(expected & 0xFF));
        }

        [TestMethod]
        public void TestAppendFloat32()
        {
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            float value = 25.48F;
            uint expected = Scale.ToInt(value);
            buffer.AppendData(value, 0.0F, false);
            Assert.IsTrue(buffer.Length == 4);
            Assert.IsTrue(buffer.Data[0] == (byte)((expected >> 24) & 0xFF));
            Assert.IsTrue(buffer.Data[1] == (byte)((expected >> 16) & 0xFF));
            Assert.IsTrue(buffer.Data[2] == (byte)((expected >> 8) & 0xFF));
            Assert.IsTrue(buffer.Data[3] == (byte)(expected & 0xFF));
        }

        [TestMethod]
        public void TestMultipleAppend()
        {
            var idx = 0;
            var data = new byte[256];
            var buffer = new Buffer();
            buffer.Init(data);
            Assert.IsTrue(buffer.Length == 0);

            // byte
            buffer.AppendData((byte)0x53);
            buffer.AppendData((byte)0x21);
            Assert.IsTrue(buffer.Data[idx++] == 0x53);
            Assert.IsTrue(buffer.Data[idx++] == 0x21);
            Assert.IsTrue(buffer.Length == idx);

            // bool
            buffer.AppendData(true);
            Assert.IsTrue(buffer.Data[idx++] == 0x01);
            Assert.IsTrue(buffer.Length == idx);

            // enum
            buffer.AppendData(AdcControlType.CurrentNoReverseBrakeButton);
            Assert.IsTrue(buffer.Data[idx++] == (byte)AdcControlType.CurrentNoReverseBrakeButton);

            // ushort
            buffer.AppendData((ushort)0x4321);
            Assert.IsTrue(buffer.Data[idx++] == 0x43);
            Assert.IsTrue(buffer.Data[idx++] == 0x21);

            // short
            buffer.AppendData((short)0x4321);
            Assert.IsTrue(buffer.Data[idx++] == 0x43);
            Assert.IsTrue(buffer.Data[idx++] == 0x21);
        }

        [TestMethod]
        public void TestGetByte()
        {
            int idx = 0;
            byte[] data = { 0xFA };
            var buffer = new Buffer();
            buffer.Init(data, 1);
            var value = buffer.GetData<byte>(ref idx);
            Assert.IsTrue(value == 0xFA);
        }

        [TestMethod]
        public void TestGetBool()
        {
            int idx = 0;
            byte[] data = { 1 };
            var buffer = new Buffer();
            buffer.Init(data, 1);
            var value = buffer.GetData<bool>(ref idx);
            Assert.IsTrue(value == true);
        }

        [TestMethod]
        public void TestGetEnum()
        {
            int idx = 0;
            byte[] data = { (byte)AdcControlType.CurrentNoReverseBrakeAdc };
            var buffer = new Buffer();
            buffer.Init(data, 1);
            var value = (AdcControlType)buffer.GetData<byte>(ref idx);
            Assert.IsTrue(value == AdcControlType.CurrentNoReverseBrakeAdc);
        }

        [TestMethod]
        public void TestGetUShort()
        {
            int idx = 0;
            byte[] data = { 0x12, 0x34 };
            var buffer = new Buffer();
            buffer.Init(data, 1);
            var value = buffer.GetData<ushort>(ref idx);
            Assert.IsTrue(value == 0x1234);
        }

        [TestMethod]
        public void TestGetShort()
        {
            int idx = 0;
            byte[] data = { 0x12, 0x34 };
            var buffer = new Buffer();
            buffer.Init(data, 1);
            var value = buffer.GetData<short>(ref idx);
            Assert.IsTrue(value == 0x1234);
        }

        [TestMethod]
        public void TestGetFloat16()
        {
            int idx = 0;
            byte[] data = { 0x12, 0x34 };
            var buffer = new Buffer();
            uint ival = 0x1234;
            var fval = Scale.ToFloat(ival);
            buffer.Init(data, 1);
            var value = buffer.GetData<float>(ref idx, 0.0f, true);
            Assert.IsTrue(value == fval);
        }

        [TestMethod]
        public void TestGetFloat32()
        {
            int idx = 0;
            byte[] data = { 0x12, 0x34, 0x56, 0x78 };
            var buffer = new Buffer();
            uint ival = 0x12345678;
            var fval = Scale.ToFloat(ival);
            buffer.Init(data, 1);
            var value = buffer.GetData<float>(ref idx, 0.0f, false);
            Assert.IsTrue(value == fval);
        }

        [TestMethod]
        public void TestDeserialization()
        {
            float[] valuesIn = { 0.50f, 0.1f, 233, 132.5f, 0.50f, 0.54f, 2 };
            float[] valuesOut = new float[valuesIn.Length];
            byte[] dataIn = new byte[256];
            var bufferIn = new Buffer();
            bufferIn.Init(dataIn);

            for (int i = 0; i < valuesIn.Length; i++)
            {
                bufferIn.AppendData(valuesIn[i]);
            }

            byte[] serializedData = new byte[dataIn.Length];
            bufferIn.Data.CopyTo(serializedData, 0);

            var bufferOut = new Buffer();
            bufferOut.Init(serializedData, serializedData.Length);

            int idx = 0;
            for (int i = 0; i < valuesOut.Length; i++)
            {
                valuesOut[i] = bufferOut.GetData<float>(ref idx);
                Assert.IsTrue(valuesIn[i] == valuesOut[i]);
            }
        }
    }
}
