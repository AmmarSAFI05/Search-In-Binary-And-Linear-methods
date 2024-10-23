using System;

namespace BinarySearch
{
    class LinearSearchRecursive
    {
        public static int LinearSearch(int[] arr, int target, int index)
        {
            if (index >= arr.Length)
                return -1; 
            // Target not found

            if (arr[index] == target)
                return index;
            // Target found at current index

            return LinearSearch(arr, target, index + 1);
        }
    }

    class BinarySearchInteractive
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }
    }
            class Program
            {
                static void Main()
                {
                    int[] arr = new int[50];
                    int start = 25;
                    //Fill Array
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = start++;
                    }


                    //Binary Search
                    Console.WriteLine("Enter the target value to search:");
                    int target = int.Parse(Console.ReadLine());

                    int binaryResult = BinarySearchInteractive.BinarySearch(arr, target);
                    Console.WriteLine("(Binary Search)");
                    if (binaryResult == -1)
                        Console.WriteLine("Target not found in the array.");
                    else
                        Console.WriteLine("Target found at index: " + binaryResult);
            Console.WriteLine("======================");


            //Linear Search
            int linearResult = LinearSearchRecursive.LinearSearch(arr, target, 0);
                    if (linearResult == -1)
                        Console.WriteLine("Target not found in the array.");
                    else
                        Console.WriteLine("Target found at index: " + linearResult);
            Console.WriteLine("======================");
        }
    }
        } 
