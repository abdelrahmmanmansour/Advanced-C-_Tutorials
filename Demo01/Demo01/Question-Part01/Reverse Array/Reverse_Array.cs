using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01.Reverse_Array
{
    internal static class Reverse
    {
        #region Method to Print an array of Any Data Type
        // Method to Print an array of Any Data Type: 
        public static void Print_Arr<T>(T[] arr)
        {
            if (arr is not null && arr.Length > 0)
            {
                foreach (T Value in arr)
                {
                    Console.Write($"{Value} ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Method to reverse an array of Any Data Type
        // Method to reverse an array of Any Data Type:
        public static void Reverse_Arr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                // Swap the elements at index i and index arr.Length - 1 - i
                T temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
        #endregion
    }
}
