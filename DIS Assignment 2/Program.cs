using System;

namespace DIS_Assignment_2
{
    class Program: utility.util
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello....");
            //Question 1
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = rotLeft(a, 4);
            displayArray(b);
            //Question 2
            int[] c = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine("Max no. of toys :" + maximumToys(c, 50).ToString());
            //Question 7
            int[] d = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            a = quickSort(d, 0, a.Length - 1);
            displayArray(d);
            Console.ReadKey(true);
        }//end of main
    }
}
