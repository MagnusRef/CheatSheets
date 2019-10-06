using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primtaludregner
{
    class Program
    {
        static bool CalcIsPrime(int number)
        {

            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false; // Even number     
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("██████╗██████╗█████╗   ███████████╗█████╗██╗");
            Console.WriteLine("██╔══████╔══████████╗ ████╚══██╔══██╔══████║");
            Console.WriteLine("██████╔██████╔████╔████╔██║  ██║  █████████║ ");
            Console.WriteLine("██╔═══╝██╔══██████║╚██╔╝██║  ██║  ██╔══████║");
            Console.WriteLine("██╔═══╝██╔══██████║╚██╔╝██║  ██║  ██╔══████║");
            Console.WriteLine("██║    ██║  ██████║ ╚═╝ ██║  ██║  ██║  █████████╗");
            Console.WriteLine("╚═╝    ╚═╝  ╚═╚═╚═╝     ╚═╝  ╚═╝  ╚═╝  ╚═╚══════╝");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-Magnus Refsgaard Christoffersen");
            Console.WriteLine("Primtalfremviser (PUBLIC DOMAIN) ");
            Console.WriteLine("________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 31; i++) // if i > 31 then it will crash due to too large integer
            {
                if (CalcIsPrime(i) == true)
                {
                    Console.WriteLine(i + " er et primtal");
                    double p = Math.Pow(2, (double)i)-1;

                    if (CalcIsPrime(Convert.ToInt32(p)) == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("fuldkomnetal af " + i + " er: " + Math.Pow(2, (double)i - 1) * (Math.Pow(2, (double)i) - 1));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(i + " har ikk et fuldkomnetal.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " er IKKE et primtal");
                    Console.ForegroundColor = ConsoleColor.White;
                }
               
            
            }   
            Console.ReadLine();
        }
        
    }
}
