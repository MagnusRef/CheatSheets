using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // her bruger vi klassen Random til at lave objektet rnd.
            string[] binArr = new string[5]; //et string array med 5 værdier (0-4)
            int score = 0; // disse to tal variabler bruger vi til at spore brugerens fremskridt.
            int wrong = 0;
            for (int i = 0; i < binArr.Length; i++) //her har vi et for loop der giver 5 tilfældige binær tal til vores string array.
            {
                binArr[i] = Convert.ToString(rnd.Next(1, 30), 2); // i rnd.Next(x, y) har vi to agumenter. ved at ændre dem kan vi vælge hvilke tal vi får.
            }
            Console.WriteLine("Christian Mørk er altid på talentjagt."); // Her har vi en hilsen fra CM, og en forklaring på hvad vi skal.
            Console.WriteLine("Christian Mørk ønsker dig held og lykke med spillet.");
            Console.WriteLine("Vinder du, får du en lille præmie.");
            Console.WriteLine("De bedste hilsener fra Christian mørk.");
            Console.WriteLine("og så er vi i gang...\n");
            for (int i = 0; i < binArr.Length+1; i++) // her har vi vores hoved loop, vi bruger int i til at gå igennem string arrayet, plus for at se hvor mange gange loopet har kørt.
            {
                if (score >= 3)
                {
                    Console.WriteLine("Tillykke, du har vundet! ");// Her udskrives vinderens hilsen, og kan kun udskrives hvis man får 3 rigtige.
                    Console.WriteLine("Kontakt mig på telefon 0x24688E8.\n");
                    Console.WriteLine("Venlig hilsen Christian..\n");
                    Console.WriteLine("Fortsat god festival og husk nu at få din præmie!");
                    break;
                }
                if (wrong >= 3)
                {
                    //TODO lad den rigtige taber hilsen...
                    Console.WriteLine("\nDu ramte rigtigt " + score + " gange og mangler derfor "+ (3-score) + " rigtige svar for at vinde."); // Her udskrives taber hilsen, og kan kun udskrives hvis man får 3 forkert.
                    Console.WriteLine("Tak fordi du spillede med. Fortsat god festival!");
                    break;
                }
                if (i < 5) //dette er hvis man ikke har svaret mere end 3 forkert eller 3 rigtige.
                {
                    Console.Write(binArr[i] + ":");
                    string stranswer = Console.ReadLine();
                    int answer = Convert.ToInt32(stranswer);
                    if (Convert.ToString(answer, 2) == binArr[i])
                    {
                        score++;
                        //Console.WriteLine("Du har svaret " + binArr[i] + " Rigtigt."); // her fortæller vi brugeren at han fik rigtigt.
                    }
                    else
                    {
                        wrong++;
                        //Console.WriteLine("Du har svaret " + binArr[i] + " Forkert."); // her fortæller vi brugeren at han fik forkert.
                    }
                }
            }
            //Luk
            Console.Write("Tryk ENTER for at lukke programmet.");
            Console.ReadLine(); // 
        }
    }
}
