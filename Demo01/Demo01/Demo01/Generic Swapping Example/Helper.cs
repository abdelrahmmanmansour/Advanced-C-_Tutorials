using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Generic_Swapping_Example
{
    internal static class Helper
    {
        #region All These Not Generic Methods
        // Generic Swapping Example:
        // Method to Swap Two Integer Values:
        // This Method is Not Generic:
        //public static void Swap_Values(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        // Method to Swap Two Points Values:
        // This Method is Not Generic:
        //public static void Swap_Values(ref Point p01, ref Point p02)
        //{
        //    Point temp = p01;
        //    p01 = p02;
        //    p02 = temp;
        //}


        // Method to Search an Integer Value in an Array:
        // Linear Search Example:
        //public static int Linear_Search(int[]arr,int Value)
        //{
        //    // if the array is not null or empty && length of the array is greater than 0
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == Value)
        //            {
        //                Console.Write("The Index Of This Value : ");
        //                return i; // Return the index of the found value
        //            }
        //        }
        //    }
        //    Console.Write("The Index Of This Value : ");
        //    return -1; // Return -1 if the value is not found  
        //}

        // Method To Sort an Array of Integers Using Bubble Sort Algorithm:

        public static void Print_Array<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }
        //public static void Bubble_Sort(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i -1; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    Swap_Values(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion


        #region Generic Methods
        // Generic Swapping Example:
        // Method to Swap Two Values of Any Type:
        // This Method is Generic:
        public static void Swap_Values<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        // Method to Search an Integer Value in an Array:
        // Linear Search Example:
        public static int Linear_Search<T>(T[] arr, T Value) where T : IEquatable<T>
        {
            // if the array is not null or empty && length of the array is greater than 0
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    // Note: Not All Data Types Support == Operator
                    // Use Equals Method for Comparison(this is exsist in any type)
                    if (arr[i].Equals(Value))
                    {
                        Console.Write("The Index Of This Value : ");
                        return i; // Return the index of the found value
                    }
                }
            }
            Console.Write("The Index Of This Value : ");
            return -1; // Return -1 if the value is not found  
        }
        // Method to Search an Integer Value in an Array with Custom Equality Comparer:
        public static int Linear_Search<T>(T[] arr, T Value, IEqualityComparer<T> equalityComparer)
        {
            // if the array is not null or empty && length of the array is greater than 0
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    // Note: Not All Data Types Support == Operator
                    // Use Equals Method for Comparison(this is exsist in any type)
                    if (equalityComparer.Equals(arr[i], Value))
                    {
                        Console.Write("The Index Of This Value : ");
                        return i; // Return the index of the found value
                    }
                }
            }
            Console.Write("The Index Of This Value : ");
            return -1; // Return -1 if the value is not found  
        }

        // Method To Sort an Array of Any Data Using Bubble Sort Algorithm:
        public static void Bubble_Sort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            Swap_Values(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }

        public static void Bubble_Sort<T>(T[] arr, IComparer<T> comparer)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                        {
                            Swap_Values(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
