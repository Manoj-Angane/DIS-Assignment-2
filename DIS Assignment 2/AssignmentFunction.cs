using System;
using System.Collections.Generic;
using System.Text;

namespace DIS_Assignment_2
{
    class AssignmentFunction : utility.util
    {
        public static int[] closestNumbers(int[] a)
        {
            var list = new List<int>();
            int difference=maxArray(a);
            a = quickSort(a,0,a.Length-1);
            displayArray(a);
            for(int i=0;i<a.Length-1;i++)
            {
                if(difference>(a[i+1]-a[i]))
                {
                    difference = a[i + 1] - a[i];
                    list.Clear();
                    list.Add(a[i]);
                    list.Add(a[i + 1]);
                }
                else if(difference == (a[i + 1] - a[i]))
                {
                    list.Add(a[i]);
                    list.Add(a[i + 1]);
                }
            }
            int[] d = list.ToArray();
            Console.WriteLine(difference);
            return d;
            

        }// end of closest Number
        
        public static int maximumToys(int[] a, int d)
        {
            a = quickSort(a, 0, a.Length - 1);
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= d)
                {
                    d = d - a[i];
                    count++;
                }
            }
            return count;
        }//end max toy function
    }
}
