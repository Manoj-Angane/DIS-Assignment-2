using System;

namespace utility
{
    class util
    {
        public static int[] rotLeft(int[] a, int d)
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
        }//left rotate function
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
        public static void displayArray(int[] d)
        {
            foreach (var item in d)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }
        public static int[] quickSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionArray(a, low, high);

                a = quickSort(a, low, pi - 1);
                a = quickSort(a, pi + 1, high);
            }
            return a;
        }
        public static int partitionArray(int[] a, int low, int high)
        {
            int pivot = a[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (a[j] < pivot)
                {
                    i++;
                    a = swapInArray(a, i, j);
                }
            }
            a = swapInArray(a, i + 1, high);
            return (i + 1);
        }
        public static int[] swapInArray(int[] a, int b, int c)
        {
            int temp = a[b];
            a[b] = a[c];
            a[c] = temp;
            return a;
        }

        public static void selectSort(int[] arr)
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
           
        }

    }
}


