using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyppighedsopgaveMAT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] observationssæt = { 4, 2, 2, 7, 10, 4, 10, 2, 4, 7, 10, 10};
            int[] obs = { 4, 2, 2, 7, 10, 4, 10, 2, 4, 7, 10, 10 };
            int antalobservationer = observationssæt.Length;
            int mindsteVærdi = observationssæt.Min();
            int størsteVærdi = observationssæt.Max();
            int variationsbredde = størsteVærdi - mindsteVærdi;
            int middeltal = (int)observationssæt.Average();
            int typetal = observationssæt.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;
            Console.Write("observationssæt: ");
            for (int i = 0; i < observationssæt.Length; i++)
            {
                Console.Write(observationssæt[i] + " ");
            }
            Console.WriteLine("\nantal observationer: " + antalobservationer);
            Console.WriteLine("mindsteVærdi: " + mindsteVærdi);
            Console.WriteLine("størsteVærdi: " + størsteVærdi);
            Console.WriteLine("variationsbredde: " + variationsbredde);
            Console.WriteLine("Gennemsnit (middeltal): " + middeltal);
            Console.WriteLine("typetal: " + typetal);
            Array.Sort(observationssæt);
            Console.Write("obs: ");
            int[] obstal = new int[4];
            for (int x = 0; x < observationssæt.Length; x++)
            {
               
                if (x != observationssæt.Length-1 && observationssæt[x] == observationssæt[x+1])
                {
                    Array.Clear(observationssæt, x, 1);
                    //Array.Resize(ref observationssæt, observationssæt.Max()- x);
                }
                if (observationssæt[x] != 0)
                {
                    Console.Write(observationssæt[x] + " ");
                }
            }
            int obs1 = 0;
            int obs2 = 0;
            int obs3 = 0;
            int obs4 = 0;
            
            for (int y = 0; y < obs.Length; y++)
            {
                if (obs[y] == 2)
                {
                    obs1++;
                }
                if (obs[y] == 4)
                {
                    obs2++;
                }
                if (obs[y] == 7)
                {
                    obs3++;
                }
                if (obs[y] == 10)
                {
                    obs4++;
                }
            }
            int sum = obs1;
            int fSum = obs1;
            Console.WriteLine("\nhyp: " + obs1 + " " + obs2 + " " + obs3 + " " + obs4);
            Console.WriteLine("fre: " + obs1 + "/" + obs.Length + " " + obs2 + "/" + obs.Length + " " + obs3 + "/" + obs.Length + " " + obs4 + "/" + obs.Length);
            Console.WriteLine("Hyp: " + sum + " " + (sum+=obs2) + " " + (sum+=obs3) + " " + (sum+=obs4));
            Console.WriteLine("fre: " + obs1 + "/" + obs.Length + " " + (fSum+=obs2) + "/" + obs.Length + " " + (fSum+=obs3) + "/" + obs.Length + " " + (fSum+=obs4) + "/" + obs.Length);
            Console.ReadLine();
        }
    }
}
