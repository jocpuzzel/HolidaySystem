using System;
using System.Collections.Generic;

namespace HolidaySystem
{
    public class HolidayService : IHolidayService
    {
        List<Holiday> IHolidayService.CheckHolidaysForDate(DateTime dateTime)
        {
            return new List<Holiday> {
                new Holiday
                {
                    Name = "Bob"
                }
            };
        }
    }
}