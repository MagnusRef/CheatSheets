using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datoer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int totalOfSunday = 0;
            for (int i = 1; i < 31; i++)
            {
                DateTime dt = new DateTime(1867, 5, i); //y, m, d
                int dayNumber = (int)dt.DayOfWeek;
                if (dayNumber == 0)
                {
                    Console.WriteLine(i);
                    totalOfSunday++;
                }
            }
            Console.WriteLine("der var " + totalOfSunday +" søndage i maj 1867");
            */
            ///
            ///
            ///
            ///
            DateTime dt1 = new DateTime(1865, 1, 1);
            DateTime dt2 = new DateTime(1865, 12, 31);
            int totalyearofsunday = 0;
            while (dt1.Date != dt2.Date)
            {
                int day = (int)dt1.DayOfWeek;
                if (day == 0)
                {
                    totalyearofsunday++;
                    //Console.WriteLine(dt1.ToString("dd/MM/yyyy"));
                }
                dt1 = dt1.AddDays(1);
            }
            Console.WriteLine("Der var " + totalyearofsunday + " i 1865");
            DateTime dt3 = new DateTime(1864, 1, 1);
            DateTime dt4 = new DateTime(1864, 12, 31);
            DateTime dt5 = new DateTime(1866, 1, 1);
            DateTime dt6 = new DateTime(1866, 12, 31);
            int totalofsundayin1864 = 0;
            int totalofsundayin1866 = 0;
            while (dt3.Date != dt4.Date)
            {
                int day2 = (int)dt3.DayOfWeek;
                if (day2 == 0)
                {
                    totalofsundayin1864++;
                }
                dt3 = dt3.AddDays(1);
            }
            while (dt5.Date != dt6.Date)
            {
                int day3 = (int)dt5.DayOfWeek;
                if (day3 == 0)
                {
                    totalofsundayin1866++;
                }
                dt5 = dt5.AddDays(1);
            }
            Console.WriteLine("søndage i 1864: " + totalofsundayin1864);
            Console.WriteLine("søndage i 1866: " + totalofsundayin1866);






            Console.ReadLine();
        }
    }
}
