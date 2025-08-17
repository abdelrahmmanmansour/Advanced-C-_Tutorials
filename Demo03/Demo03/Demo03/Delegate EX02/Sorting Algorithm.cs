using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Delegate_EX02
{
    // Make Delegate To Refer Address Of Compare Operator:
    //public delegate bool DelegateFuncCompare(int a,int b);
    //public delegate bool DelegateFuncCompareString(string a,string b);
    public delegate bool DelegateFuncCompare<T>(T a, T b);
    internal static class Sorting_Algorithm
    {
        //// Metod To Sorting integer Values Ascending:
        //public static void BubbleSortAscending(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (Compare.CompareGreater(arr[j] , arr[j + 1]))
        //            {
        //                Swap(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //// Metod To Sorting integer Values Descinding:
        //public static void BubbleSortDescinding(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (Compare.CompareLess(arr[j] , arr[j + 1]))
        //            {
        //                Swap<int>(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        // If I Have Two Function => Same Code with different operator:
        // make this operator as function
        // Make One Function has Paremter => Have Address This Function
        public static void BubbleSort<T>(T[] arr, DelegateFuncCompare<T> Ref)
        {
            if (arr == null || arr.Length == 0) return;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (Ref.Invoke(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        //public static void BubbleSort(string[] arr, DelegateFuncCompareString Ref)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (Ref.Invoke(arr[j], arr[j + 1]))
        //            {
        //                Swap(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}
        // Swap Two Variables:
        private static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
    }
}
