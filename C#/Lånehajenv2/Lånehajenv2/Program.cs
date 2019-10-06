using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lånehajenv2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lån;
            double rente;
            double ydelse;
            int terminer;
            Console.WriteLine("Lånehajen version 2");
            Console.WriteLine("oprettelse gebyr er på 25 kr.");
            Console.Write("Indtast hvor meget du vil låne:");
            string strLån = Console.ReadLine();
            lån = Convert.ToDouble(strLån);
            if (lån >= 5000)
            {
                rente = 1.075;
                Console.WriteLine("Din rente er på 7.5%");
                Console.WriteLine("forslag til mindste månedlig ydelse " + lån / 100 * 7.5);
            }
            else
            {
                rente = 1.10;
                Console.WriteLine("Din rente er på 10%");
                Console.WriteLine("forslag til mindste månedlig ydelse " + lån / 100 * 10);
            }
            Console.Write("indtast ydelse per termin:");
            string strydelse = Console.ReadLine();
            ydelse = Convert.ToDouble(strydelse);
            Console.WriteLine("forslag til terminer " + lån/ydelse);
            Console.Write("indtast terminer (2-24):");
            string strTerminer = Console.ReadLine();
            terminer = Convert.ToInt32(strTerminer);
            for (int i = 1; i < terminer; i++)
            {

                lån = rente / 100 * (lån / 1) - Math.Pow(rente, -i);
                Console.WriteLine(lån);
            }






            Console.ReadLine();
        }
    }
}
