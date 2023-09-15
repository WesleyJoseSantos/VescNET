using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VescNET.Infra;

namespace Test.Infra
{
    [TestClass]
    public class ScaleTests
    {
        [TestMethod]
        public void GeneralTest()
        {
            float[] fvalsIn = { 0.50f, 0.1f, 233, 132.5f, 0.50f, 0.54f, 2 };
            uint[] ivalsIn = new uint[fvalsIn.Length];
            uint[] ivalsOut = new uint[fvalsIn.Length];
            float[] fvalsOut = new float[fvalsIn.Length];

            for (int i = 0; i < fvalsIn.Length; i++)
            {
                ivalsIn[i] = Scale.ToInt(fvalsIn[i]);
            }

            for (int i = 0; i < ivalsOut.Length; i++)
            {
                fvalsOut[i] = Scale.ToFloat(ivalsIn[i]);
                Assert.IsTrue(fvalsIn[i] == fvalsOut[i]);
            }
        }
    }
}
