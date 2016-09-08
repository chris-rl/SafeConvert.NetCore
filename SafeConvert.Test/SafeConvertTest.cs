using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace SafeConvert.Test
{
    [TestClass]
    public class SafeConvertTest
    {
        [TestMethod]
        public void ConvertToByte_MinValue_Okay()
        {
            var s = (byte.MinValue).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(s.ToByte(), byte.MinValue);
        }

        [TestMethod]
        public void ConvertToByte_OutOfRangeMaxValue_NonOkay()
        {
            var n = (Byte.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(n.ToByte(), 0);
        }

        [TestMethod]
        public void ConvertToByte_OutOfRangeMinValue_NonOkay()
        {
            var n = (Byte.MinValue - 1).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(n.ToByte(), 0);
        }

        [TestMethod]
        public void ConvertToShort_MinValue_Okay()
        {
            var s = (short.MinValue).ToString();
            Assert.AreEqual(s.ToInt16(), short.MinValue);
        }

        [TestMethod]
        public void ConvertToShort_OutOfRangeMaxValue_NonOkay()
        {
            var n = (short.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(n.ToInt16(), 0);
        }

        [TestMethod]
        public void ConvertToShort_OutOfRangeMinValue_NonOkay()
        {
            var n = (short.MinValue - 1).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(n.ToInt16(), 0);
        }

        [TestMethod]
        public void ConvertToInt_MinValue_Okay()
        {
            var s = (int.MinValue).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(s.ToInt32(), int.MinValue);
        }

        [TestMethod]
        public void ConvertToInt_OutOfRangeMaxValue_NonOkay()
        {
            var s = ((long)int.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(s.ToInt32(), 0);
        }

        [TestMethod]
        public void ConvertToInt_OutOfRangeMinValue_NonOkay()
        {
            var s = ((long)int.MinValue - 1).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(s.ToInt32(), 0);
        }

        [TestMethod]
        public void ConvertToLong_MinValue_Okay()
        {
            var s = (long.MinValue).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(s.ToInt64(), long.MinValue);
        }

        [TestMethod]
        public void ConvertToLong_MaxValue_Okay()
        {
            var s = (long.MaxValue).ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(s.ToInt64(), long.MaxValue);
        }

        [TestMethod]
        public void ConvertToFloat_SpecifiedValue_Okay()
        {
            Assert.AreEqual("6.5".ToSingle(), 6.5f);
        }

        [TestMethod]
        public void ConvertToDecimal_SpecifiedValue_Okay()
        {
            Assert.AreEqual("6.5".ToDecimal(), 6.5M);
        }

        [TestMethod]
        public void ConvertToDouble_SpecifiedValue_Okay()
        {
            Assert.AreEqual("6.5".ToDecimal(), (decimal)6.5);
        }

        [TestMethod]
        public void ConvertToDateTime_SpecifiedValue_Okay()
        {
            Assert.AreEqual("2014-12-02 11:00:00".ToDateTime(), new DateTime(2014, 12, 2, 11, 0, 0));
        }

        [TestMethod]
        public void ConvertToDateTime_NoValidFormatSpecifiedValue_NonOkay()
        {
            Assert.AreEqual("2014//12//02 11:00:00".ToDateTime(), default(DateTime));
        }

        [TestMethod]
        public void ConvertToAny_SpecifiedIntegerValue_Okay()
        {
            Assert.AreEqual("20".To<int>(), 20);
        }
    }
}