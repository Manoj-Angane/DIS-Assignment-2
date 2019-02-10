using System;
using System.Collections;

namespace DIS_Assignment_2
{
    class Program: DIS_Assignment_2.AssignmentFunction
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
            int[] d = new int[] { 5, 4, 3, 2 };
            //int[] d = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 };
            a = closestNumbers(d);
            displayArray(a);
            //Question 6
            int[] t = new[] {0,1,2,4,6,5,3,3};
            selectSort(t);
            int x = findMedian(t);
            Console.WriteLine(x);

            //Question 5
            int[] g = new int[] { 73, 67, 38, 33 };
            int[] res = new int[g.Length];
            res = gradingStudents(g);
            for(int i=0; i<g.Length; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey(true);
        }//end of main
    }
}
