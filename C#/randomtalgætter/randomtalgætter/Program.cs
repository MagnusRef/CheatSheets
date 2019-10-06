using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtalgætter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 1000);
            Console.WriteLine("Du skal gætte et tilfædlig tal mellem 1-1000 \n du har 3 forsøg!!!");
            for (int i = 1; i < 4; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("du har tabt! \n nummeret var " + num + " :/");
                    break;
                }
                else
                {
                    Console.Write("forsøg nr. " + i + ": ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == num)
                    {
                        Console.WriteLine("Tilykke du har vundet en havenisse!!!");
                        break;
                    }
                    else if (input > num)
                    {
                        Console.WriteLine("tallet er mindre end " + input);
                    }
                    else if (num > input)
                    {
                        Console.WriteLine("tallet er større end " + input);
                    }
                }
               
            }
            Console.ReadLine();
        }
    }
}
