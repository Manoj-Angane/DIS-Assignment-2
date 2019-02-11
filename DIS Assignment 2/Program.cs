using System;
using System.Collections;
using System.Collections.Generic;

namespace DIS_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
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
            int[] temp = new int[a.Length];
            for (int j = 0; j < a.Length; j++)
            {
                if (j - d >= 0)
                {
                    temp[j - d] = a[j];
                }
                else
                {
                    temp[a.Length - d + j] = a[j];
                }
            }
            return temp;            
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            prices = selectSort(prices);
            int count = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= k)
                {
                    k = k - prices[i];
                    count++;
                }
            }
            return count;
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
            

            arr=selectSort(arr);
            brr =selectSort(brr);
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
            var list = new List<int>();
            int difference = maxArray(arr);
            arr = selectSort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (difference > (arr[i + 1] - arr[i]))
                {
                    difference = arr[i + 1] - arr[i];
                    list.Clear();
                    list.Add(arr[i]);
                    list.Add(arr[i + 1]);
                }
                else if (difference == (arr[i + 1] - arr[i]))
                {
                    list.Add(arr[i]);
                    list.Add(arr[i + 1]);
                }
            }
            int[] d = list.ToArray();
            //Console.WriteLine(difference);
            return d;
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            string res = "";
            int day = 256;
            int a = leapYear(year);
            if (year > 1918)
            {
                switch (a)
                {
                    case 0:
                        res = dayCal(year, "comm", day);
                        break;
                    case 1:
                        res = dayCal(year, "leap", day);
                        break;
                    default:
                        throw new System.ArgumentException("Invalid Calender Year", year.ToString());
                }
            }
            else if (year < 1918)
            {
                switch (leapYear(year, "Julian"))
                {
                    case 1:
                        res = dayCal(year, "leap", day);
                        break;
                    case 0:
                        res = dayCal(year, "comm", day);
                        break;
                    default:
                        throw new System.ArgumentException("Invalid Calender Year", year.ToString());
                }
            }
            else
            {
                res = dayCal(year, "spcl", day);
            }
            return res;

        }
        public static string dayCal(int year, string typ, int day)
        //provide year, type of year like leap,Normal=comm, spcl case of 1918 for russia and number of day to return date of number of date.
        {
            int[] mon = new int[12];
            int[] leap = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] comm = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] spcl = new int[] { 31, 15, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            switch (typ)
            {
                case "leap":
                    mon = leap;
                    break;
                case "comm":
                    mon = comm;
                    break;
                case "spcl":
                    mon = spcl;
                    break;
                default:
                    throw new System.ArgumentException("invalid type of year", typ);
            }
            int i = 0;
            string res = "dd.mm.yyyy";
            while (day > mon[i])
            {
                day -= mon[i];
                i++;
            }
            res = day.ToString() + "." + (i + 1).ToString() + "." + year.ToString();
            return res;
        }

        public static int [] selectSort(int[] arr)
        {
            int pos_min, temp;
            for (int i = 0; i < arr.Length; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        pos_min = j;
                    }
                }
                //Swapping below
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
            return arr;

        }

        public static int maxArray(int[] a)
        {
            int max = 0;
            foreach (var item in a)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static int leapYear(int year, string cal = "Gregorian")
        //return 1 if year is leap for Gregorian and Julian Calendar; Gregorian is by defalaut.
        {
            switch (cal.ToLower().Trim())
            {
                case "julian":
                    {
                        if (year % 4 == 0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                case "gregorian":
                    {
                        if (year % 400 == 0)
                        {
                            return 1;
                        }
                        else if (year % 100 != 0 && year % 4 == 0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                default:
                    {
                        throw new System.ArgumentException("Invalid Calender Year", cal);
                    }
            }
        }//end of leap year

    }//end of class

}//end of name space
