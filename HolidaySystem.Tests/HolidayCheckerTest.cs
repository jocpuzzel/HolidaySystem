using NUnit.Framework;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace HolidaySystem.Tests
{
    public class HolidayCheckerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckHolidayForDateReturnsOnePerson()
        {
            IHolidayService holidayService = new HolidayService();

            List<Holiday> holidays = holidayService.CheckHolidaysForDate(new System.DateTime(2021, 2, 10));

            Assert.AreEqual(1, holidays.Count);
        }

        [Test]
        public void CheckHolidayForDateReturnsBob()
        {
            IHolidayService holidayService = new HolidayService();

            List<Holiday> holidays = holidayService.CheckHolidaysForDate(new System.DateTime(2021, 2, 10));

            Assert.AreEqual("Bob", holidays.First().Name);
        }
    }
}