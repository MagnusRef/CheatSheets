using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace påskedagformula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Gregorian algorithm \nMRC TEC D54");
            int turns = 0;
            while (turns < 5)
            {
                Console.Write("Indtast et årstal>");
                int y = Convert.ToInt32(Console.ReadLine());
                int a = y % 19, b = y / 100, c = y % 100, d = b / 4, e = b % 4;
                int f = (b + 6) / 25, g = (b - f + 1) / 3, h = (19 * a + b - d - g + 15) % 30;
                int i = c / 4, k = c % 4, l = (32 + 2 * e + 2 * i - h - k) % 7;
                int m = (a + 11 * h + 22 * l) / 451, month = (h + l - 7 * m + 114) / 31;
                int day = ((h + l - 7 * m + 114) % 31) + 1;
                DateTime dt = new DateTime(y, month, day);
                Console.WriteLine("påske dag er " + dt.ToLongDateString());
                turns++;
            }
            Console.ReadLine();

        }
    }
}
