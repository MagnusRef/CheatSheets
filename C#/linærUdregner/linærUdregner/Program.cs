using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linærUdregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linær udregner version 1 \nMagnus R. Christoffersen \n__________________________________________________________________________");
            Console.WriteLine(" første grafslining  y=ax+b ");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine())/10;
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine())/10;
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine())/10;
            Console.WriteLine("y = " + a + " * " + x + " + " + b);
            Console.WriteLine(a + " er oplyftningen");
            Console.WriteLine(x + " er ...");
            Console.WriteLine(b + " er y skæringspunktet");
            Console.WriteLine("y = " + (a*x+b));









            Console.ReadLine();
        }
    }
}
