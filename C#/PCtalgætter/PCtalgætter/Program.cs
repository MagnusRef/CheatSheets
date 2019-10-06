using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCtalgætter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computeren skal gætte et tal mellem  1-100");
            Console.Write("Indtast et tal mellem 1-100: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\ner tallet mindre end 50? (+/-):");
            string svar = Console.ReadLine();
            if (svar == "+") // mindre end 50 
            {
                Console.WriteLine("er tallet mindre end 25? (+/-):");
                svar = Console.ReadLine();
                if (svar == "+")
                {
                    Console.WriteLine("er tallet mindre end");
                }
            }
            else if (svar == "-") // større end 50
            {

            } 
            Console.ReadLine();
        }
    }
}
