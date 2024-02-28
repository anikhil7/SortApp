/*
Author: Nikhil Alla
U_ID: U58683362
Date: 02/28/2024
Comments: This C# Console Application code demonstrates the
    Selection Sort Algorithm. No input
    is required for the script. It will execute without 
    input against one pre-populated array. 
*/

namespace SortApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] selection_sort_numbers = { 5, 72, 3, 14, 7, 1 };
            Console.WriteLine("These are the Numbers before Sorting.!");
            foreach (int i in selection_sort_numbers)
            {
                Console.Write(i);
                Console.Write(' ');
            }
            Console.WriteLine();
            int[] sorted_arr = Selection_Sort(selection_sort_numbers);
            Console.WriteLine("These are the Numbers after Sorting.!");
            foreach (int i in sorted_arr)
            {
                Console.Write(i);
                Console.Write(' ');
            }

        }

        static int[] Selection_Sort(int[] arr)
        {
            int n = arr.Length;
            int[] sortedArr = new int[n];
            Array.Copy(arr, sortedArr, n);

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (sortedArr[j] < sortedArr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = sortedArr[minIndex];
                sortedArr[minIndex] = sortedArr[i];
                sortedArr[i] = temp;
            }

            return sortedArr;
        }
    }
}