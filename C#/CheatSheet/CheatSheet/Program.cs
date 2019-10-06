using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheatSheet
{
    class Program
    {
        static void Main(string[] args)
        {


            // data Typer
            byte red = 255; // data type fra 0-255
            sbyte green = 127; // data type fra -128-127
            int age = 18; // data type fra -13 mia. til 13 mia.
            double pi = 3.14; // data type til decimaler (HUSK i BRUGE AMERIKANSKE Tal system)
            string name = "Magnus"; //datatype til bogstaver og ord.


            // input & output
            Console.WriteLine("skriv dit navn");
            string brugernavn = Console.ReadLine();
            Console.WriteLine("dit navn er: " + brugernavn);


            // data type manipulition 
            string sx = "10";
            Convert.ToInt64(sx); // converter data typer fx. Todouble, ToInt, ToString ...  det er et ex. på en manual data konvertering.



            //loops
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            for (int i1 = 0; i1 < 10; i1++)
            {

                Console.WriteLine(i1);
            }
            int i2 = 0;
            do
            {
                Console.WriteLine(i2);
                i2 = i2 + 1;

            }
            while (i2 <= 10);

            //Arrays
            int[] numarr = new int[5];
            numarr[0] = 10; //element
            numarr[1] = 98;
            numarr[2] = 10; 
            numarr[3] = 31;
            numarr[4] = 22; // or do
            byte[] addarr = { 192, 168, 1, 1};
            

            int[] arr = { 10, 11, 12, 13};
            for (int t = 0; t < arr.Length; t++)
            {
                Console.Write(arr[t] + ", ");
            }
            int arrSum = arr.Sum(); // or int arrSum = arr[0] + arr[1] + arr[2] + arr[3];
            int arrMin = arr.Min();
            /*
            arrSum = 0;
            for (int u = 0; u < arr.Length; u++)
            {
                arrSum += arr[u];
            }
            */
            int arrMax = arr.Max();
            Array.Sort(arr); // well in this instance we don't need this..
            int arrMed = arr.Length / 2; 
            int arrAvg = arr[0] + arr[1] + arr[2] + arr[3] / arr.Length; // or just int arrAvg = arr.Average(); or int arrAvg = arrSum/arr.Length;
            Console.WriteLine("\nSum:" + arrSum);
            Console.WriteLine("Min: " + arrMin);
            Console.WriteLine("Max: " + arrMax);
            Console.WriteLine("Range: " + arrMax + "-" + arrMin);
            Console.WriteLine("Avg: " + arrAvg);
            Console.WriteLine("Median: " + arr[arrMed]);

            //substrings

            string fornavn = "mAgNuS";
            string efternavn = "chRistoFfErsen";

            fornavn = fornavn.ToLower();
            string fornavni = fornavn.Substring(0, 1).ToUpper();

            efternavn = efternavn.ToLower();
            string efternavni = efternavn.Substring(0,1).ToUpper();

            Console.WriteLine(fornavn.Remove(1).ToUpper() + fornavn.Substring(1));
            Console.WriteLine(efternavn.Remove(1).ToUpper() + efternavn.Substring(1));
            Console.WriteLine(fornavni + efternavni);
            



            // ###########################
            // ######### Øvelser #########
            // ###########################
            // Fibonacci Øvelse
            int x = 1;
            int y = 1;
            int sum = 0;
            Console.WriteLine("0");
            Console.WriteLine("1");
            Console.WriteLine("1");

            while (y < 89)
            {
                sum = x + y;
                Console.WriteLine(sum);
                x = y;
                y = sum;
            }
            // vægt øvelse

            Console.WriteLine("Indtast vægt (kg)");

            
            bool glad = false;
            while(glad == false)
            {
                string svar = Console.ReadLine();
                double vægt;
                try
                {
                    vægt = Convert.ToDouble(svar);
                    glad = true;
                    Console.WriteLine("Mange Tak");
                    if (Convert.ToInt64(vægt) >= 30)
                    {
                        Console.WriteLine("dit vægt er over 30 kg, Programmet kan med 100% sikkerhed at du ikke har en spiseforsyrelse.");
                    }
                    else
                    {

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    
                }
                

            }
            // Skudårs øvelse (leap year exerices)
            Console.WriteLine("Skriv et årstal for at tjekke om det et skudår (fx. 1990)");
            string strBrugerIn = Console.ReadLine();
            int intBrugerIn = Convert.ToInt32(strBrugerIn);
            if (intBrugerIn % 4 == 0 /*& intBrugerIn % 400 == 0*/)
            {
                if (intBrugerIn % 100 != 100)
                {
                    Console.WriteLine(intBrugerIn + " er  et skud år");
                }
                else
                {
                    if (intBrugerIn % 400 == 0)
                    {
                        Console.WriteLine(intBrugerIn + " er et skud år");
                    }
                    else
                    {
                        Console.WriteLine(intBrugerIn + " er IKKE et skud år");
                    }                   
                }
                
            }
            else /*if (intBrugerIn % 100 == 0)*/
            {
                Console.WriteLine(intBrugerIn + " er IKKE et skud år");
            }
            // Array For loop øvelse
            /*
            int[] arr0 = {0, 2, 4, 6, 8};
            int sum1 = 0;
            for (int i1 = 0; i1 < arr0.Length; i1++)
            {
                sum1 = sum1 + arr0[i];
                Console.WriteLine(sum);
            }//Array Øvelse nr 2 


            int[] arr1 = { 0, 2, 4, 6, 8 };
            int[] arr2 = new int[5];
            for (int i3 = 0; i3 < arr2.Length; i3++)
            {
                arr2[i3] = arr1[i3] + 2;
            }
            */

            











            Console.ReadLine();

            



       















        }
    }
}
