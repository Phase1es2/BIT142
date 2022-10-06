// Hao Yang
// 11/21/2019
// Major Assignment 4.cs
// Purpose: helps us to undersatand how passing array and ...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algoridham
{
    class Program
    {
        static void Main(string[] args)
        {
            String userChoice;
            int number, searchNumber, index;
            Console.WriteLine("Hello! Welcome to my Searching and Sorting Algorithm\n");
            Console.Write("What search and sort method would you like to do ?");
            userChoice = Console.ReadLine();
            Console.Write("\nHow many number do you have?");
            number = Convert.ToInt16(Console.ReadLine());
            int[] numArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("\nPlease enter a number: ");
                numArray[i] = Convert.ToInt16(Console.ReadLine());
            }
            if (userChoice == "Binary Search")
            {
                Console.Write("\nWhat number do you looking for? ");
                searchNumber = Convert.ToInt16(Console.ReadLine());
                index = binarySearch(numArray, 0, number - 1, searchNumber);
                if (index == -1)
                    Console.WriteLine("\nThe element you are looking for is not in the list.");
                else
                    Console.WriteLine("\nThe element you are looking for is at index " + index);
            }
            if (userChoice == "Linear Search")
            {
                Console.Write("\nWhat number do you looking for? ");
                searchNumber = Convert.ToInt16(Console.ReadLine());
                index = linearSearch(numArray, searchNumber);
                if (index == -1)
                    Console.WriteLine("\nThe element you are looking for is not in the list.");
                else
                    Console.WriteLine("\nThe element you are looking for is at index " + index);
            }
            if (userChoice == "Bubble Sort")
            {
                bubbleSort(numArray);
                Console.WriteLine("\nAfter sorting usding bubble sort Array is: ");
                for (int i = 0; i < numArray.Length; i++)
                {
                    Console.WriteLine(numArray[i]);
                }
            }
        }
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        static int linearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        static int binarySearch(int[] arr, int l,
        int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }

    }
}