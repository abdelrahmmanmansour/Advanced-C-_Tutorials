using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01.Even_Values
{
    internal static class Even_Numbers
    {

        #region Method to print even numbers from an array of any type
        // Method to print even numbers from an array of any type:
        public static void Print_Even_Numbers<T>(T[] arr)
        {
            Console.Write("The Even Values are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr is not null && arr.Length > 0)
                {
                    // Convert to dynamic to handle different numeric types
                    dynamic value = arr[i];
                    if (value % 2 == 0)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                }
            }
            Console.WriteLine();
        }
        #endregion
    }
}
