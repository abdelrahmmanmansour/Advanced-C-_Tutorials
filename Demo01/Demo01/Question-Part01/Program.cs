using Question_Part01.Task_one_BananaRipenessRange;
using Question_Part01.Task_two_MultiBox;
using Question_Part01.Range_Values;
using Question_Part01.Reverse_Array;
using Question_Part01.Even_Values;
using System;
using System.Collections;
namespace AdvancedC__Session_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tasks:

            #region Task 1 => BananaRipenessRange<T>
            // Task 1 => BananaRipenessRange<T>:
            // Create an instance of BananaRipenessRange with int type
            //BananaRipenessRange<int> bananaRipenessRange = new BananaRipenessRange<int>(5, 8);
            //if (bananaRipenessRange.IsPerfectBanana(7))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            // Create an instance of BananaRipenessRange with float type
            //BananaRipenessRange<float> bananaRipenessRange01 = new BananaRipenessRange<float>(5.5f, 8.9f);
            //if (bananaRipenessRange01.IsPerfectBanana(9))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            #endregion

            #region Task 2 => MultiBox<T>
            // Task 2 => MultiBox<T>:
            // Create an instance of MultiBox with int type
            //MultiBox<int> multiBox = new MultiBox<int>(2);
            //multiBox.Insert_Item(1);
            //multiBox.Insert_Item(2);
            //multiBox.Insert_Item(3);
            //multiBox.Insert_Item(4);
            //multiBox.GetAllItems();
            //Console.WriteLine(multiBox.GetCount());

            // Create an instance of MultiBox with string type
            //MultiBox<string> multiBox01 = new MultiBox<string>(4);
            //multiBox01.Insert_Item("Red");
            //multiBox01.Insert_Item("Green");
            //multiBox01.Insert_Item("Blue");
            //multiBox01.Insert_Item("Orange");
            //multiBox01.Insert_Item("Black");
            //multiBox01.GetAllItems();
            //Console.WriteLine(multiBox01.GetCount()); 
            #endregion

            // Assignment:

            #region 1.1 - create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range
            // 1.1 - create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range:
            //Range<double> range = new Range<double>(20.5, 10.5);
            //Console.WriteLine(range.Get_Length());
            //if (range.IsInRange(20))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("Flase");
            //} 
            #endregion

            #region 1.2 - You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements
            // 2.2 - You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements:
            // Make ArrayList of integers:
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("**** Before Reverse ****");
            //Reverse.Print_Arr(arr);
            //Console.WriteLine("**** After Reverse ****");
            //Reverse.Reverse_Arr(arr);
            //Reverse.Print_Arr(arr);

            // Make ArrayList of strings:
            //string[] arr01 = { "Mansour", "Sara", "Mohamed" };
            //Console.WriteLine("**** Before Reverse ****");
            //Reverse.Print_Arr(arr01);
            //Console.WriteLine("**** After Reverse ****");
            //Reverse.Reverse_Arr(arr01);
            //Reverse.Print_Arr(arr01); 
            #endregion

            #region 1.3 - You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list
            // 1.3 - You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list: 
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Even_Numbers.Print_Even_Numbers(Arr);
            //double[] Arr01 = { 1, 2.0, 3, 4, 5, 6.0, 7, 0.8, 9, 10 };
            //Even_Numbers.Print_Even_Numbers(Arr01);
            #endregion

            #region 1.4 - implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices
            // 1.4 - implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices: 
            // ******* I Make this Task in the Task_two_MultiBox folder *******
            // Create an instance of MultiBox with int type
            //MultiBox<int> multiBox = new MultiBox<int>(2);
            //multiBox.Insert_Item(10);
            //multiBox.Insert_Item(20);
            //multiBox.Insert_Item(30);
            //multiBox.Insert_Item(4);
            //multiBox.GetAllItems();
            //Console.WriteLine(multiBox.GetCount());

            // Create an instance of MultiBox with string type
            //MultiBox<string> multiBox01 = new MultiBox<string>(4);
            //multiBox01.Insert_Item("Englad");
            //multiBox01.Insert_Item("Germany");
            //multiBox01.Insert_Item("Italy");
            //multiBox01.Insert_Item("France");
            //multiBox01.Insert_Item("Japan");
            //multiBox01.GetAllItems();
            //Console.WriteLine(multiBox01.GetCount());
            #endregion
        }
    }
}

