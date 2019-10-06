using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Array_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            // ###########################
            // ######### min kode #########
            // ###########################
            //Vi skal finde alle Fællesmængderne mellem A, B og C!
            /*
            String[] A = { "a", "b", "c" };
            String[] B = { "a", "b", "c", "d" };
            String[] C = { "b", "c", "d" };
            String[] comAtB = new String[5];
            String[] comBtC = new String[5]; 
            String[] comCtA = new String[5]; 
            int totalLen = A.Length + B.Length + C.Length;
            bool AtB = A.SequenceEqual(B);
            bool BtC = B.SequenceEqual(C);
            bool CtA = C.SequenceEqual(A);

            if (AtB == true)
            {
                for (int i = 0; i < B.Length; i++)
                {
                    if (A[i] == B[i])
                    {
                        comAtB[i] = A[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (BtC == true)
            {
                for (int u = 0; u < B.Length; u++)
                {
                    if (B[u] == C[u])
                    {
                        comBtC[u] = B[u];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (CtA==true)
            {
                for (int o = 0; o < A.Length; o++)
                {
                    if (C[o] == A[o])
                    {
                        comCtA[o] = C[o];
                    }
                }
            }
            //execute
            Console.Write("Fællesmængderne mellem A og B: ");
            for (int p = 0; p < comAtB.Length; p++)
            {
                Console.Write(comAtB[p]);
            }
            Console.Write("\nFællesmængderne mellem B og C: ");
            
            for (int e = 0; e < comAtB.Length; e++)
            {
                Console.Write(comBtC[e]);
            }
            Console.Write("\nFællesmængderne mellem C og A: ");
            for (int q = 0; q < comAtB.Length; q++)
            {
                Console.Write(comCtA[q]);
            }
            */

            // ###########################
            // ######### lære kode #########
            // ###########################
            String[] A = { "a", "b", "c" };
            String[] B = { "a", "b", "c", "d" };
            String[] C = { "b", "c", "d" };
            for (int i1 = 0; i1 < B.Length; i1++)
            {
                for (int i2 = 0; i2 < B.Length; i2++)
                {
                    if (A[i1] == B[i2])
                    {
                        Console.WriteLine(A[i1]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
