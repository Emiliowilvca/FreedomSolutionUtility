using Freedom.Utility.Interfaces;
using System;
using System.Globalization;

namespace Freedom.Utility.Implements
{
    //public class DateConvert : IDateConvert
    //{
    //    public string ToLongDateWithoutWeekDayString(DateTime source)
    //    {
    //        var s1 = source.ToLongDateString();
    //        var dayname = DateTimeFormatInfo.CurrentInfo.GetDayName(source.DayOfWeek);
    //        var s2 = s1.Replace(dayname, "");
    //        return s2.TrimStart(", ".ToCharArray());
    //    }

    //    public DateTime SetTimeEndOfDay(DateTime d)
    //    {
    //        return new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
    //    }

    //    public string ConvertTimeEndOfDay(DateTime d)
    //    {
    //        var dt = new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
    //        return dt.ToString("yyyy/MM/dd HH:mm:ss");
    //    }

    //    public DateTime SetTimeFirstOfDay(DateTime d)
    //    {
    //        return new DateTime(d.Year, d.Month, d.Day, 0, 0, 1);
    //    }

    //    public string ConverTimeFirstOfDay(DateTime d)
    //    {
    //        var dt = new DateTime(d.Year, d.Month, d.Day, 0, 0, 1);
    //        return dt.ToString("yyyy/MM/dd HH:mm:ss");
    //    }

    //    public DateTime GetFirstDayOfMonth(DateTime d)
    //    {
    //        return new DateTime(d.Year, d.Month, 1, 0, 0, 1);
    //    }

    //    public DateTime GetLastDayOfMonth(DateTime d)
    //    {
    //        var tmp = new DateTime(d.Year, d.Month, 1).AddMonths(1).AddDays(-1);
    //        return new DateTime(d.Year,
    //                            d.Month,
    //                            tmp.Day,
    //                            d.Hour,
    //                            d.Minute,
    //                            d.Second);
    //    }

    //    public DateTime CreateNewDatetime(DateTime d)
    //    {
    //        return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
    //    }

    //    public DateTime CreateNowDate(DateTime d)
    //    {
    //        DateTime dx = DateTime.Now;
    //        return new DateTime(d.Year, d.Month, d.Day, dx.Hour, dx.Minute, dx.Second);
    //    }

    //    public DateTime SetCurrentHourToDateUTC(DateTime d)
    //    {
    //        var c = DateTime.UtcNow;
    //        return new DateTime(d.Year, d.Month, d.Day, c.Hour, c.Minute, c.Second);
    //    }
    //}
}