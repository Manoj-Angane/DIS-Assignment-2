using System;
using System.Collections;

namespace DIS_Assignment_2
{
    class Program: DIS_Assignment_2.AssignmentFunction
    {
        static void Main(string[] args)
        {
           
          /*  //Question 1
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
           

            
            }*/

             // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine(findMedian(arr2));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));

            Console.ReadKey(true);
        }//end of main

         static void displayArray(int []arr) {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            return new int[] {};
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            return 0;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            int len = arr.Count;
            int left = 0;
            int right = len-1;
            int sum_left = 0;
            int sum_right = 0;
            while (left<len && right >=0)
            {
                //Console.WriteLine("left: " + left + " right: " + right + " sum_left: " + sum_left + " Sum Right: " + sum_right);
                if(sum_left == sum_right && (left - right) == 0)
                {
                    //Console.WriteLine("1");
                    return "YES";
                }//end of if
                else if(sum_left<sum_right)
                {
                    //Console.WriteLine("2");
                    sum_left += arr[left];
                     left++;
                }
                else //if(sum_left>sum_right)
                {
                    //Console.WriteLine("3");
                    sum_right += arr[right];
                     right--;
                 }

             }//end of while

             return "NO";

            
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {


            var missing = new List<int>();
            int len_arr = arr.Length;
            int len_brr = brr.Length;
            

            arr=quickSort(arr,0,len_arr-1);
            brr = quickSort(brr,0,len_brr-1);
            int temp = brr[0];
            int arr_match = 0;
            int brr_match = 0;
            for (int k = 0; k < len_brr; k++)
            {
                arr_match = 0;
                brr_match = 0;
                if (k == 0 || temp != brr[k])
                {
                    temp = brr[k];

                    for (int j = 0; j < len_arr; j++)
                    {
                        if (temp == arr[j])
                        {
                            arr_match++;
                        }
                    }
                    for (int i = 0; i < len_brr; i++)
                    {
                        if (brr[i] == temp)
                        {
                            brr_match++;
                        }
                    }//end of second 
                    //Console.WriteLine(arr_match + " " + brr_match);
                    if (brr_match - arr_match > 0)
                    {
                        missing.Add(temp);
                    }
                }
            }
                int[] d = missing.ToArray();
            return d;
           
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            List<int> result = new List<int>();
            int[] r3 = new int[grades.Length];
            
            for (int i = 0; i< grades.Length; i++)
            {
                if (grades[i] <38)
                {
                    result.Add(grades[i]);
                }
                if (grades[i] >= 38)
                {
                    int d = grades[i] / 5;
                    int n = (d + 1) * 5;
                    if( (n -grades[i]) <3)
                    {
                        result.Add(n);
                    }
                    else
                    {
                        result.Add(grades[i]);
                    }
                }
            }

             r3=result.ToArray();
            return r3;
            
        }
                   
        // Complete the findMedian function below.
        static int findMedian(int[] arr2)
        { 
            selectSort(arr2);
            int temp = arr2.Length;
            int median = (temp + 1) / 2;
            return arr2[median-1];
            
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            return "";
        }


    }//end of class

}//end of name space
