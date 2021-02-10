using System;
using System.Collections.Generic;

namespace HolidaySystem
{
    public interface IHolidayService
    {
        List<Holiday> CheckHolidaysForDate (DateTime dateTime);
    }
}