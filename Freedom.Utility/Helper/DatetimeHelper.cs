using System;
using System.Globalization;

namespace Freedom.Utility
{
    public static class DatetimeHelper
    {
        public static bool IsValidDate(this string date, IFormatProvider provider, DateTimeStyles dateTimeStyles)
        {
            return DateTime.TryParse(date, provider, dateTimeStyles, out _);
        }

        public static bool IsValidDate(this string date)
        {
            if (date == null) return false;
            return DateTime.TryParse(date, out _);
        }

        /// <summary>
        /// Convert Datetime to int (yyyyMMddHHmmss)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static long ToInteger(this DateTime datetime)
        {
            string datestring = datetime.ToString("yyyyMMddHHmmss");
            return Convert.ToInt64(datestring);
        }

        /// <summary>
        /// Convert to datetime from integer
        /// </summary>
        /// <param name="date">yyyyMMddHHmmss format</param>
        /// <returns></returns>
        public static DateTime ToDatetime(this long date)
        {
            var result = DateTime.TryParseExact(date.ToString(), "yyyyMMddHHmmss", CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out var nuevo);
            return result ? nuevo : DateTime.UtcNow;
        }


        /// <summary>
        /// Convert String to datetime utc hour
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public static DateTime ToDateTimeUtcNow(this string dateString)
        {
            if(string.IsNullOrEmpty(dateString)) return DateTime.UtcNow;

            if (DateTime.TryParse(dateString, out DateTime current))
            {
                return current.ToDateTimeUTC();
            }
            return DateTime.UtcNow;
        }

        /// <summary>
        /// Convert string to datetime local hour
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public static DateTime ToDatetimeNow(this string dateString)
        {
            if (string.IsNullOrEmpty(dateString)) return DateTime.Now;

            if (DateTime.TryParse(dateString, out DateTime current))
            {
                return current.ToDateTimeLocal();
            }
            return DateTime.Now;
        }



        public static DateTime ToDatetimeFirstOfDay(this string dateString)
        {
           if (string.IsNullOrEmpty(dateString)) 
                return DateTime.Now;

            if (DateTime.TryParse(dateString, out DateTime current))
            {
                return current.SetTimeFirstOfDay();
            }
            return DateTime.Now.SetTimeFirstOfDay();
        }

        public static DateTime ToDatetimeEndOfDay(this string dateString)
        {
            if (DateTime.TryParse(dateString, out DateTime current))
            {
                return current.SetTimeEndOfDay();
            }
            return DateTime.Now.SetTimeEndOfDay();
        }

      
        public static string ToLongDateWithoutWeekDayString(this DateTime source)
        {
            string s1 = source.ToLongDateString();
            string dayname = DateTimeFormatInfo.CurrentInfo.GetDayName(source.DayOfWeek);
            string s2 = s1.Replace(dayname, "");
            return s2.TrimStart(", ".ToCharArray());
        }

        public static DateTime SetTimeEndOfDay(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
        }

        public static string ConvertTimeEndOfDay(this DateTime d)
        {
            DateTime dt = new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
            return dt.ToString("yyyy/MM/dd HH:mm:ss");
        }

        /// <summary>
        /// Convert datetime to string mysql date format (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToSqlDatetime(this DateTime d)
        {
            return d.ToString("yyyy-MM-dd HH:mm:ss");
        }


        /// <summary>
        /// Convert date to first hour day string mysql date format (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToSqlDatetimeFirstOfDay(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, 0, 0, 1)
                         .ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// Convert date to end hour of day,  mysql date format (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToSqlDatetimeEndOfDay(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, 23, 59, 59)
                        .ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static DateTime SetTimeFirstOfDay(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, 0, 0, 1);
        }


        /// <summary>
        /// convert datetime to string first of day (yyyy/MM/dd HH:mm:ss)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ConverTimeFirstOfDay(this DateTime d)
        {
            DateTime dt = new DateTime(d.Year, d.Month, d.Day, 0, 0, 1);
            return dt.ToString("yyyy/MM/dd HH:mm:ss");
        }

        public static DateTime GetFirstDayOfMonth(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, 1, 0, 0, 1);
        }

        public static DateTime GetLastDayOfMonth(this DateTime d)
        {
            DateTime tmp = new DateTime(d.Year, d.Month, 1).AddMonths(1).AddDays(-1);
            return new DateTime(d.Year,
                                d.Month,
                                tmp.Day,
                                d.Hour,
                                d.Minute,
                                d.Second);
        }

        public static DateTime CreateNewDatetime(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }

        public static DateTime CreateNowDate(this DateTime d)
        {
            DateTime dx = DateTime.Now;
            return new DateTime(d.Year, d.Month, d.Day, dx.Hour, dx.Minute, dx.Second);
        }


        /// <summary>
        /// convert date to server datetime 
        /// </summary>
        /// <param name="d"> datetime</param>
        /// <returns> utc server datetime </returns>
        public static DateTime ToDateTimeUTC(this DateTime d)
        {
            DateTime c = DateTime.UtcNow;
            return new DateTime(d.Year, d.Month, d.Day, c.Hour, c.Minute, c.Second);
        }


        /// <summary>
        /// convert date to local datetime 
        /// </summary>
        /// <param name="d"> datetime </param>
        /// <returns> local pc datetime </returns>
        public static DateTime ToDateTimeLocal(this DateTime d)
        {
            DateTime c = DateTime.Now;
            return new DateTime(d.Year, d.Month, d.Day, c.Hour, c.Minute, c.Second);
        }

        
    }
}