using System;
using System.Collections;
using System.Collections.Generic;

namespace DIS_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // left rotation
                Console.WriteLine("Left Rotation");
                int[] a = { 1, 2, 3, 4, 5 };
                int d = 4;
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
                int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
                int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
                int[] r2 = missingNumbers(arr1, brr);
                displayArray(r2);

                // grading students
                Console.WriteLine("\n\nGrading students");
                int[] grades = { 73, 67, 38, 33 };
                int[] r3 = gradingStudents(grades);
                displayArray(r3);

                // find the median
                Console.WriteLine("\n\nFind the median");
                int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
                Console.WriteLine(findMedian(arr2));

                // closest numbers
                Console.WriteLine("\n\nClosest numbers");
                int[] arr3 = { 5, 4, 3, 2 };
                int[] r4 = closestNumbers(arr3);
                displayArray(r4);

                // Day of programmer
                Console.WriteLine("\n\nDay of programmer");
                int year = 2017;
                Console.WriteLine(dayOfProgrammer(year));

                Console.ReadKey(true);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error While excuting Code. Error: " + e);
            }
        }//end of main

        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] temp = new int[a.Length];//creating temporary array of input array size
            if (d < 0)//checking if input index for rotation is positive
            {
                Console.WriteLine("Please positive value rotate value");//throwing error
                return temp;//return array with 0 value
            }
            else
            {

                for (int j = 0; j < a.Length; j++)//loop for length of array time iteration
                {
                    if (j - d >= 0)//if calcutated index is positive
                    {
                        temp[j - d] = a[j];
                    }
                    else//for calculated index value for negative value adding index in opposite direction
                    {
                        temp[a.Length - d + j] = a[j];
                    }
                }
                return temp;//returning rotated array
            }
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            prices = selectSort(prices);//sorting array using selectsort
            int count = 0;//intialising count variable to 0
            for (int i = 0; i < prices.Length; i++)//loop to check number of toy's we can by.
            {
                if (prices[i] <= k)//checking if we have cash more than next toy's price
                {
                    k = k - prices[i];
                    count++;
                }
                else//if cash is less than next toy's price
                {
                    break;//stop checking
                }
            }
            return count;//return final count
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            int len = arr.Count;//save length of array
            int left = 0;
            int right = len - 1;
            int sum_left = 0;
            int sum_right = 0;
            while (left < len && right >= 0)//loop till left is less than length of array and right greater than 0
            {
                if (sum_left == sum_right && left - right == 0)//if sum is greater than 0 and left and right is different
                {
                    return "YES";
                }//end of if
                else if (sum_left < sum_right)//if sum of right side is greater than sum of right side
                {
                    sum_left += arr[left];
                    left++;
                }
                else //if sum_left>sum_right
                {
                    sum_right += arr[right];
                    right--;
                }

            }//end of while
            if (sum_right == sum_left)//check if sum left and right are equal
            {
                return "YES";
            }
            else
            {
                return "NO";
            }


        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            var missing = new List<int>();//intialising list.
            int len_arr = arr.Length;
            int len_brr = brr.Length;
            arr = selectSort(arr);//sorting array using selection sort
            brr = selectSort(brr);//sorting array using selection sort
            int temp = brr[0];//intialising temp variable with first element of array
            int arr_match = 0;
            int brr_match = 0;
            for (int k = 0; k < len_brr; k++)//loop to check for all variable from super set
            {
                arr_match = 0;
                brr_match = 0;
                if (k == 0 || temp != brr[k])
                {
                    temp = brr[k];

                    for (int j = 0; j < len_arr; j++)//loop to count in subset
                    {
                        if (temp == arr[j])
                        {
                            arr_match++;
                        }
                    }
                    for (int i = 0; i < len_brr; i++)//loop to count in superset
                    {
                        if (brr[i] == temp)
                        {
                            brr_match++;
                        }
                    }//end of second 

                    if (brr_match - arr_match > 0)//count differ in both array
                    {
                        missing.Add(temp);
                    }
                }
            }
            int[] d = missing.ToArray();//convert list to array
            return d;//return final array

        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            List<int> result = new List<int>();  // created a list and named it as result
            int[] r3 = new int[grades.Length];  //  created a array r3 of length of input array. 

            // for-loop assigning the numeric grade for different ranges of grade-marks
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38)    // assigning grade-marks for value less than 38
                {
                    result.Add(grades[i]);
                }
                if (grades[i] >= 38)  // // assigning grade-marks for grade more than 38 according to asked conditions
                {
                    int d = grades[i] / 5;
                    int n = (d + 1) * 5;
                    if ((n - grades[i]) < 3)
                    {
                        result.Add(n);
                    }
                    else
                    {
                        result.Add(grades[i]);
                    }
                }
            }

            r3 = result.ToArray();
            return r3;

        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr2)
        {
            selectSort(arr2); // selectSort to sort the input array
            int temp = arr2.Length;   // temp variable to store the length of input array
            int median = (temp + 1) / 2;   // median variable to store index of median
            return arr2[median - 1];  // printing the value of median index

        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            var list = new List<int>();//create list

            arr = selectSort(arr);//sort array
            int difference = arr[arr.Length - 1];//find max value of array
            for (int i = 0; i < arr.Length - 1; i++)//rotate till length of array
            {
                if (difference > (arr[i + 1] - arr[i]))//last saved difference is greater than current difference
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
            int[] d = list.ToArray();//convert list in array
            //Console.WriteLine(difference);
            return d;
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            string res = "";
            int day = 256;
            int a = leapYear(year);//check for Gregorian leap year
            if (year > 1918)//check for Gregorian's year
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
            else if (year < 1918)//check for Julian year
            {
                switch (leapYear(year, "Julian"))//check for leapYear julian switch
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
            else//spl case of year 1918
            {
                res = dayCal(year, "spcl", day);
            }
            return res;

        }
        public static string dayCal(int year, string typ, int day)
        //provide year, type of year like leap,Normal=comm, spcl case of 1918 for russia and number of day to return date of number of date.
        {
            int[] mon = new int[12];
            int[] leap = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };//intialising array of day of month for leap year 
            int[] comm = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };//intialising array of day of month
            int[] spcl = new int[] { 31, 15, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };//intialising array of day of month for special years
            switch (typ)//check with type of case
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
            while (day > mon[i])//remaining day is greater than current selected month days
            {
                day -= mon[i];
                i++;
            }
            res = day.ToString() + "." + (i + 1).ToString() + "." + year.ToString();//return final string
            return res;//return string
        }

        public static int[] selectSort(int[] arr)
        {
            int pos_min, temp; // pos_min will store the index of the minimum value, temp variable is used for swapping.

            // for-loop for every pass
            for (int i = 0; i < arr.Length; i++)
            {
                pos_min = i;
                // for-loop for assigning the index of minimum value to pos_min 
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        pos_min = j;
                    }
                }
                //Swapping 
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
            return arr;

        }

        public static int leapYear(int year, string cal = "Gregorian")
        //return 1 if year is leap for Gregorian and Julian Calendar; Gregorian is by defalaut.
        {
            switch (cal.ToLower().Trim())//check for type of calendar
            {
                case "julian"://case for Julian Calendar
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
                case "gregorian"://case for Gregorian Calendar
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