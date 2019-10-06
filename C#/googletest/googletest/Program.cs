using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace googletest
{
    class Program
    {
        static int[] Sort(int[] arr)
        {


            Array.Sort(arr);
            return arr;
        }
        static void Main(string[] args)
        {
            /*
            int[] arr1 = { 0, 0, 2, 5, 1 };
            int[] arr2 = { 0, 3, 4, 1, 8 };
            int[] arrSum = new int[5];

            for (int i = 0; i < arr1.Length; i++)
            {
                arrSum[i] = arr1[i] + arr2[i];
                Console.WriteLine(arr1[i] + "+" + arr2[i] + "=" + arrSum[i]);
            }
            */
            int[] arr3 = { 0, 0, 9, 5, 4 };
            int[] arr4 = { 0, 0, 2, 4, 8 };
            
            string strArr1 = "0";
            string strArr2 = "0";
            for (int i = 0; i < arr3.Length; i++)
            {
                strArr1 = strArr1 + Convert.ToString(arr3[i]);
                strArr2 = strArr2 + Convert.ToString(arr4[i]);
                //Console.WriteLine(arr3[i] + "+" + arr4[i] + "=" + arrSum2[i]);
            }
            int iarr1 = Convert.ToInt32(strArr1);
            int iarr2 = Convert.ToInt32(strArr2);
            int iarrSum = iarr1 + iarr2;
            string strsum = "0" + Convert.ToString(iarrSum);
            string[] strArrSum = new string[5];
            for (int i = 1; i < arr3.Length; i++)
            {
                strArrSum[i] = strsum.Substring(i, 1);
            }
            Console.WriteLine(iarr1 + "+" + iarr2 + "=" + iarrSum);
            Console.ReadLine();





        }
    }
}
