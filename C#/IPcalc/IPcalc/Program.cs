using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an IP Address (192.168.1.10):");
            string strIP = Console.ReadLine();
            Console.Write("\nEnter a subnet mask (255.255.255.0): ");
            string strSNM = Console.ReadLine();
            string[] strIpAdr = strIP.Split('.');
            string[] strSNMAdr = strSNM.Split('.');
            int[] ipAdr = new int[4];
            int[] subNM = new int[4];
            int[] netAdr = new int[4];
            for (int i = 0; i < strIpAdr.Length; i++) // Converting string array to int array.
            {
                ipAdr[i] = Convert.ToInt32(strIpAdr[i]);
                subNM[i] = Convert.ToInt32(strSNMAdr[i]);
            }
            for (int x = 0; x < ipAdr.Length; x++) //"calc the 2 arrays into another array"
            {
                netAdr[x] = subNM[x] & ipAdr[x];

            }
            Console.Write("\nYour Network Address is: ");
            System.Threading.Thread.Sleep(1000); // just for kicks really
            for (int u = 0; u < netAdr.Length-1; u++) //showing the result to the user.
            {
                Console.Write(netAdr[u] + ".");
                //System.Threading.Thread.Sleep(500);
            }
            Console.Write(netAdr.Length-1);
            Console.WriteLine("\nThe program executed correctly, press ANY button to close the window and terminate the program.");
            Console.ReadLine();



        }
    }
}
