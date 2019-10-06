using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string fornavn = "mAgNuS";
            string efternavn = "chRistoFfErsen";

            fornavn = fornavn.ToLower();
            string fornavni = fornavn.Substring(0, 1).ToUpper();

            efternavn = efternavn.ToLower();
            string efternavni = efternavn.Substring(0, 1).ToUpper();

            Console.WriteLine(fornavn.Remove(1).ToUpper() + fornavn.Substring(1));
            Console.WriteLine(efternavn.Remove(1).ToUpper() + efternavn.Substring(1));
            Console.WriteLine(fornavni + efternavni);
            */

            Console.Write("indtast en sætning der skal udkrives baglæns: ");
            string str = Console.ReadLine();
            string[] strArr = new string[str.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] = str.Substring(i, 1);
            }
            Array.Reverse(strArr);
            for (int x = 0; x < strArr.Length; x++)
            {
                Console.Write(strArr[x]);
            }
            Console.ReadLine();
        }
    }
}
