namespace System
{
    /// <summary>
    /// For object, use the original Convert class
    /// For string, use the original TryParse method
    /// </summary>
    public static class SafeConvertExtensions
    {
        public static bool ToBoolean(
#if !NET20
            this
#endif
                object o, bool defaultValue = false)
        {
            try
            {
                return Convert.ToBoolean(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static bool ToBoolean(
#if !NET20
            this
#endif
                string s, bool defaultValue = false)
        {
            if (s == null) return defaultValue;

            // when parsed as '1', return true
            if (ToInt32(s) == 1) return true;

            bool n;
            return bool.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static char ToChar(
#if !NET20
            this
#endif
                object o, char defaultValue = '\0')
        {
            try
            {
                return Convert.ToChar(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static char ToChar(
#if !NET20
            this
#endif
                string s, char defaultValue = '\0')
        {
            if (s == null) return defaultValue;
            char n;
            return char.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static sbyte ToSByte(
#if !NET20
            this
#endif
                object o, sbyte defaultValue = 0)
        {
            try
            {
                return Convert.ToSByte(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static sbyte ToSByte(
#if !NET20
            this
#endif
                string s, sbyte defaultValue = 0)
        {
            if (s == null) return defaultValue;
            sbyte n;
            return sbyte.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static byte ToByte(
#if !NET20
            this
#endif
                object o, byte defaultValue = 0)
        {
            try
            {
                return Convert.ToByte(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static byte ToByte(
#if !NET20
            this
#endif
                string s, byte defaultValue = 0)
        {
            if (s == null) return defaultValue;
            byte n;
            return byte.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static short ToInt16(
#if !NET20
            this
#endif
                object o, short defaultValue = 0)
        {
            try
            {
                return Convert.ToInt16(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static short ToInt16(
#if !NET20
            this
#endif
                string s, short defaultValue = 0)
        {
            if (s == null) return defaultValue;
            short n;
            return short.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static ushort ToUInt16(
#if !NET20
            this
#endif
                object o, ushort defaultValue = 0)
        {
            try
            {
                return Convert.ToUInt16(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static ushort ToUInt16(
#if !NET20
            this
#endif
                string s, ushort defaultValue = 0)
        {
            if (s == null) return defaultValue;
            ushort n;
            return ushort.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static int ToInt32(
#if !NET20
            this
#endif
                object o, int defaultValue = 0)
        {
            try
            {
                return Convert.ToInt32(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static int ToInt32(
#if !NET20
            this
#endif
                string s, int defaultValue = 0)
        {
            if (s == null) return defaultValue;
            int n;
            return int.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static uint ToUInt32(
#if !NET20
            this
#endif
                object o, uint defaultValue = 0)
        {
            try
            {
                return Convert.ToUInt32(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static uint ToUInt32(
#if !NET20
            this
#endif
                string s, uint defaultValue = 0)
        {
            if (s == null) return defaultValue;
            uint n;
            return uint.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static long ToInt64(
#if !NET20
            this
#endif
                object o, long defaultValue = 0)
        {
            try
            {
                return Convert.ToInt64(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static long ToInt64(
#if !NET20
            this
#endif
                string s, long defaultValue = 0)
        {
            if (s == null) return defaultValue;
            long n;
            return long.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static ulong ToUInt64(
#if !NET20
            this
#endif
                object o, ulong defaultValue = 0)
        {
            try
            {
                return Convert.ToUInt64(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static ulong ToUInt64(
#if !NET20
            this
#endif
                string s, ulong defaultValue = 0)
        {
            if (s == null) return defaultValue;
            ulong n;
            return ulong.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static float ToSingle(
#if !NET20
            this
#endif
                object o, float defaultValue = 0)
        {
            try
            {
                return Convert.ToSingle(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static float ToSingle(
#if !NET20
            this
#endif
                string s, float defaultValue = 0)
        {
            if (s == null) return defaultValue;
            float n;
            return float.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static double ToDouble(
#if !NET20
            this
#endif
                object o, double defaultValue = 0)
        {
            try
            {
                var n = Convert.ToDouble(o);
                return double.IsInfinity(n) || double.IsNaN(n) ? defaultValue : n;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static double ToDouble(
#if !NET20
            this
#endif
                string s, double defaultValue = 0)
        {
            if (s == null) return defaultValue;
            double n;
            n = double.TryParse(s.Trim(), out n) ? n : defaultValue;

            return double.IsNaN(n) || double.IsInfinity(n) ? defaultValue : n;
        }

        public static decimal ToDecimal(
#if !NET20
            this
#endif
                object o, decimal defaultValue = 0)
        {
            try
            {
                return Convert.ToDecimal(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static decimal ToDecimal(
#if !NET20
            this
#endif
                string s, decimal defaultValue = 0)
        {
            if (s == null) return defaultValue;
            decimal n;
            return decimal.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static DateTime ToDateTime(
#if !NET20
            this
#endif
                object o, DateTime defaultValue = new DateTime())
        {
            try
            {
                return Convert.ToDateTime(o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static DateTime ToDateTime(
#if !NET20
            this
#endif
                string s, DateTime defaultValue = new DateTime())
        {
            if (s == null) return defaultValue;
            DateTime n;
            return DateTime.TryParse(s.Trim(), out n) ? n : defaultValue;
        }

        public static T To<T>(
#if !NET20
            this
#endif
                object o, T defaultValue = default(T))
        {
            try
            {
                return (T)Convert.ChangeType(o, typeof(T));
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static object ChangeType(
#if !NET20
            this
#endif
                object o, Type t, object defaultValue = null)
        {
            try
            {
                return Convert.ChangeType(o, t);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static TEnum ToEnum<TEnum>(
#if !NET20
            this
#endif
                string s, TEnum defaultValue = default(TEnum)) where TEnum : struct
        {
            if (s == null) return default(TEnum);
            try
            {
                return (TEnum)Enum.Parse(typeof(TEnum), s.Trim());
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static TEnum ToEnum<TEnum>(
#if !NET20
            this
#endif
                object o, TEnum defaultValue = default(TEnum)) where TEnum : struct
        {
            try
            {
                return (TEnum)Enum.ToObject(typeof(TEnum), o);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public static bool[] ToBooleanArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new bool[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToBoolean(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] ToByteArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new byte[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToByte(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static char[] ToCharArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new char[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToChar(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static short[] ToInt16Array(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new short[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToInt16(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int[] ToInt32Array(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new int[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToInt32(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static long[] ToInt64Array(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new long[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToInt64(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static sbyte[] ToSByteArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new sbyte[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToSByte(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ushort[] ToUInt16Array(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new ushort[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToUInt16(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static uint[] ToUInt32Array(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new uint[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToUInt32(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ulong[] ToUInt64Array(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new ulong[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToUInt64(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static float[] ToSingleArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new float[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToSingle(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static double[] ToDoubleArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new double[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToDouble(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static decimal[] ToDecimalArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new decimal[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToDecimal(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DateTime[] ToDateTimeArray(
#if !NET20
            this
#endif
                string[] ss)
        {
            try
            {
                var tmp = new DateTime[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    tmp[i] = ToDateTime(ss[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool[] ToBooleanArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new bool[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToBoolean(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] ToByteArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new byte[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToByte(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static char[] ToCharArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new char[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToChar(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static short[] ToInt16Array(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new short[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToInt16(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int[] ToInt32Array(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new int[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToInt32(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static long[] ToInt64Array(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new long[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToInt64(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static sbyte[] ToSByteArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new sbyte[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToSByte(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ushort[] ToUInt16Array(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new ushort[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToUInt16(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static uint[] ToUInt32Array(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new uint[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToUInt32(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ulong[] ToUInt64Array(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new ulong[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToUInt64(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static float[] ToSingleArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new float[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToSingle(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static double[] ToDoubleArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new double[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToDouble(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static decimal[] ToDecimalArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new decimal[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToDecimal(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DateTime[] ToDateTimeArray(
#if !NET20
            this
#endif
                object[] os)
        {
            try
            {
                var tmp = new DateTime[os.Length];

                for (var i = 0; i < os.Length; i++)
                {
                    tmp[i] = ToDateTime(os[i]);
                }

                return tmp;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}