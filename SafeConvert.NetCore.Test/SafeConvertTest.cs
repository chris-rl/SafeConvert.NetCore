using System;
using System.Globalization;
using Xunit;

namespace SafeConvert.NetCore.Test
{
    public class SafeConvertTest
    {
        [Fact]
        public void ConvertToByte_MinValue_Okay()
        {
            var s = (byte.MinValue).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(s.ToByte(), byte.MinValue);
        }

        [Fact]
        public void ConvertToByte_OutOfRangeMaxValue_NonOkay()
        {
            var n = (byte.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(0, n.ToByte());
        }

        [Fact]
        public void ConvertToByte_OutOfRangeMinValue_NonOkay()
        {
            var n = (byte.MinValue - 1).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(0, n.ToByte());
        }

        [Fact]
        public void ConvertToShort_MinValue_Okay()
        {
            var s = (short.MinValue).ToString();
            Assert.Equal(s.ToInt16(), short.MinValue);
        }

        [Fact]
        public void ConvertToShort_OutOfRangeMaxValue_NonOkay()
        {
            var n = (short.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(0, n.ToInt16());
        }

        [Fact]
        public void ConvertToShort_OutOfRangeMinValue_NonOkay()
        {
            var n = (short.MinValue - 1).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(0, n.ToInt16());
        }

        [Fact]
        public void ConvertToInt_MinValue_Okay()
        {
            var s = (int.MinValue).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(s.ToInt32(), int.MinValue);
        }

        [Fact]
        public void ConvertToInt_OutOfRangeMaxValue_NonOkay()
        {
            var s = ((long)int.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(0, s.ToInt32());
        }

        [Fact]
        public void ConvertToInt_OutOfRangeMinValue_NonOkay()
        {
            var s = ((long)int.MinValue - 1).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(0, s.ToInt32());
        }

        [Fact]
        public void ConvertToLong_MinValue_Okay()
        {
            var s = (long.MinValue).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(s.ToInt64(), long.MinValue);
        }

        [Fact]
        public void ConvertToLong_MaxValue_Okay()
        {
            var s = (long.MaxValue).ToString(CultureInfo.InvariantCulture);
            Assert.Equal(s.ToInt64(), long.MaxValue);
        }

        [Fact]
        public void ConvertToFloat_SpecifiedValue_Okay()
        {
            Assert.Equal(6.5f, "6.5".ToSingle());
        }

        [Fact]
        public void ConvertToDecimal_SpecifiedValue_Okay()
        {
            Assert.Equal(6.5M, "6.5".ToDecimal());
        }

        [Fact]
        public void ConvertToDouble_SpecifiedValue_Okay()
        {
            Assert.Equal("6.5".ToDecimal(), (decimal)6.5);
        }

        [Fact]
        public void ConvertToDateTime_SpecifiedValue_Okay()
        {
            Assert.Equal("2014-12-02 11:00:00".ToDateTime(), new DateTime(2014, 12, 2, 11, 0, 0));
        }

        [Fact]
        public void ConvertToDateTime_NoValidFormatSpecifiedValue_NonOkay()
        {
            Assert.Equal(default, "2014//12//02 11:00:00".ToDateTime());
        }

        [Fact]
        public void ConvertToAny_SpecifiedIntegerValue_Okay()
        {
            Assert.Equal(20, "20".To<int>());
        }
    }
}