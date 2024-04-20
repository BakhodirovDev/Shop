using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DateTimes
{
    public class ForDateTime
    {
        DateTime dates=new DateTime();
        DateTime datesNow=DateTime.Now.AddDays(-51).AddYears(4);
        DateTime datesUTCNow=DateTime.UtcNow;
        long dateMinValue = DateTime.UnixEpoch.Ticks;


        // Construstor
        DateTime datesTest = new DateTime(621355968000000000);

        DateTime datesYearMonthDay = new DateTime(2015,01,30);

        //TimeSpan



        public void Test()
        {
            TimeSpan ts = new TimeSpan(datesUTCNow.Hour, datesUTCNow.Minute, datesUTCNow.Second);

            DateTime testTimeSpan = new DateTime().Add(ts);

            //Console.WriteLine(printDateTime(dates));
            //Console.WriteLine(datesNow);
            //Console.WriteLine(printDateTime(datesUTCNow));
            //Console.WriteLine(dateMinValue);

            //Console.WriteLine(datesNow);
            //Console.WriteLine(printYearMonthDay(datesUTCNow));
            //Console.WriteLine(dateMinValue);

            //Console.WriteLine(datesTest);
            //Console.WriteLine(datesYearMonthDay);

            DateOnly dateOnly = new DateOnly(2015,02,12);
            //TimeOnly vs TimeSpan

            Console.WriteLine(datesNow);
            Console.WriteLine(ts);
            Console.WriteLine(datesNow+ts);
        }


        DateTime printDateTime(DateTime date)
        {
            return date;
        }

        (int,int, string) printYearMonthDay (DateTime date)
        {
            return (date.Day, date.Month, date.Year.ToString());
        }
    }

}
