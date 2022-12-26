using System;

namespace Freedom.Utility.RequestBase
{
    public interface IRequestDateRangue
    {
        DateTime SinceDate { get; set; }

        DateTime UntilDate { get; set; }
    }

    public interface IRequestDateIntergerRangue
    {
        long SinceDate { get; set; }

        long UntilDate { get; set; }
    }
}