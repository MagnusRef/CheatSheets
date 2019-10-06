using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinærUr
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            while (keepgoing == true)
            {
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                
                int[] arrHour = new int[8];
                int[] arrMin = new int[8];
                int[] arrSec = new int[8];
                int hour = Convert.ToInt32(Convert.ToString(dt.Hour, 2));
                int min = Convert.ToInt32(Convert.ToString(dt.Minute, 2));
                int sec = Convert.ToInt32(Convert.ToString(dt.Second, 2));
                arrHour = Array.ConvertAll(hour.ToString().ToArray(), x => (int)x - 48);
                arrMin = Array.ConvertAll(min.ToString().ToArray(), x => (int)x - 48);
                arrSec = Array.ConvertAll(sec.ToString().ToArray(), x => (int)x - 48);

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("█ █ ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < arrHour.Length; i++)
                {
                    if (arrHour[i] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("█ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("█ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    
                }
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("█ █ ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int x = 0; x < arrMin.Length; x++)
                    {
                    if (arrMin[x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("█ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("█ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("");
                for (int y = 0; y < arrSec.Length; y++)
                {
                    if (arrSec[y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("█ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("█ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("\n"+dt.ToLongTimeString());
                //Console.WriteLine(".'`~~~~~~~~~~~`'.\n(  .'11 12 1'.  )\n|  :10      2:  |\n|  :9   @-> 3:  |\n|  :8       4;  |\n'. '..7 6 5..' .'\n ~------------~");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
           
          
        }
    }
}
