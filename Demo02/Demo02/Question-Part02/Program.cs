using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Question_Part02   
{
    internal class Program
    {
        #region Print Reversed Queue Using Stack
        // Print Reversed Queue Using Stack:
        public static void Reverse_Queue_Using_Stack(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {

                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                Console.WriteLine($"{stack.Pop()} ");
            }
        }
        #endregion
        #region Check if Parentheses are Balanced Using Stack
        // Check if Parentheses are Balanced Using Stack:
        public static bool IS_Balance(string input)
        {
            // Create a stack :
            Stack<char> stack = new Stack<char>();
            foreach (char s in input)
            {
                if (s == '(' || s == '[' || s == '{')
                {
                    stack.Push(s);
                }
                else if (s == ')' || s == ']' || s == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false; // Unmatched closing parenthesis
                    }
                    char top = stack.Pop();
                    // Matching check
                    if ((s == ')' && top != '(') ||
                        (s == '}' && top != '{') ||
                        (s == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0; // If stack is empty, parentheses are balanced
        }
        #endregion
        #region Remove Duplicates from Array
        // Remove Duplicates from Array: 
        public static void Remove_Duplicates(int[] arr)
        {
            Console.Write("The Array After Remove Duplicate:  ");
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
        #endregion
        #region Remove Odd Numbers from ArrayList
        // Remove Odd Numbers from ArrayList: 
        public static void Remove_Odd_Numbers(ArrayList arrayList)
        {
            Console.Write("The Result is: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is int number && number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
            }
        }
        #endregion
        #region Push Integers onto Stack and Search for Target
        // Push Integers onto Stack and Search for Target: 
        public static void Push_Integers_And_Search_Target(int[] integers, int target)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int items in integers)
            {
                stack.Push(items);
            }
            int count = 0;
            foreach (int item in stack)
            {
                count++;
                if (item == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    return;
                }
            }
            Console.Write("Target was not found");

        }
        #endregion
        #region Print Queue Reverse First K Elements
        // Print Queue Reverse First K Elements: 
        public static void ReverseFirstKElements(Queue<int> queue, int k) // if k = 3
        {
            // Validate input
            if (queue == null || k <= 0 || k > queue.Count)
            {
                return; // Invalid input    
            }
            // Create a stack to hold the first k elements
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue()); //  3 2 1 
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop()); // 4,5,3,2,1
            }
            // Note: The remaining elements[queue.Count-k] in the queue should remain in the same order.
            for (int i = 0; i < queue.Count - k; i++)
            {
                queue.Enqueue(queue.Dequeue()); // 5,3,2,1,4  || 3,2,1,4,5
            }
        }
        #endregion
        #region Printing Items In Queue
        // Printing Items In Queue:
        public static void Printing_Queue(Queue<int> queue)
        {
            Console.Write("Items Are: ");
            foreach (int item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {
            // Assignment02:
            #region 1.1 - Given an array consists of numbers with size N and number of queries,in each query you will be given an integer X,and you should print how many numbers in array that is greater than X:
            //int SizeOfArray;
            //do
            //{
            //    Console.Write("Please Enter Size Of Array First :  ");
            //} while (!int.TryParse(Console.ReadLine(), out SizeOfArray));
            //int[] arr = new int[SizeOfArray];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Please Enter Element {i + 1} : ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //int QuerysCount;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Please Enter Query {i + 1} : ");
            //    } while (!int.TryParse(Console.ReadLine(), out QuerysCount));
            //    int Counter = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[j] > QuerysCount)
            //        {
            //            Counter++;
            //        }
            //    }
            //    Console.WriteLine($"The Output is : { Counter} ");
            //}
            #endregion
            #region 1.2 - Given a number N and an array of N numbers. Determine if it's palindrome or not:
            // Note: A palindrome is a sequence that reads the same backward as forward.
            //int SizeOfArray;
            //do
            //{
            //    Console.Write("Please Enter Size Of Array First :  ");
            //} while (!int.TryParse(Console.ReadLine(), out SizeOfArray));
            //int[] arr = new int[SizeOfArray];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Please Enter Element {i + 1} : ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    if (arr[i] != arr[arr.Length - 1 - i])
            //    {
            //        Console.WriteLine("False, The Array is not a Palindrome");
            //        return;
            //    }
            //}
            //Console.WriteLine("True, The Array is a Palindrome");
            #endregion
            #region 1.3 - Given a Queue, implement a function to reverse the elements of a queue using a stack:
            //Queue<int> queue = new Queue<int>(new int[] { 10, 20, 30, 40 });
            //Reverse_Queue_Using_Stack(queue);
            #endregion
            #region 1.4 - Given a Stack, implement a function to check if a string of parentheses is balanced using a stack:
            //Console.Write("Plaese Enter A string parentheses : ");
            //string input = Console.ReadLine();
            //if (IS_Balance(input))
            //{
            //    Console.WriteLine("The parentheses are balanced.");
            //}
            //else
            //{
            //    Console.WriteLine("The parentheses are not balanced.");
            //}
            #endregion
            #region 1.5 - Given an array, implement a function to remove duplicate elements from an array:
            //int[] arr = { 1, 2, 3, 4, 4, 6, 7, 7, 10, 20, 20, 30, 30, 100 };
            //Remove_Duplicates(arr);
            #endregion
            #region 1.6 - Given an array list , implement a function to remove all odd numbers from it:
            //ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //Remove_Odd_Numbers(arrayList);
            #endregion
            #region 1.7 - Implement a queue that can hold different data types.And insert the following data:queue.Enqueue(1),queue.Enqueue(“Apple”),queue.Enqueue(5.28):
            // Note: The Queue class is not generic, so it can hold any type of object.
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //foreach (var item in queue) // Var : keyword allows you to declare a variable without specifying its type
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 1.8 - Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).Note[take the target as input from the user]:
            //int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int target;
            //do
            //{
            //    Console.Write("Please Enter A Target U Want To Search: ");
            //} while (!int.TryParse(Console.ReadLine(), out target));
            //Push_Integers_And_Search_Target(integers, target);
            #endregion
            #region 1.9 - Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays:
            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4 };
            //Console.Write("The Duplication Of This Data: ");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (arr1[i] == arr2[j])
            //        {
            //            Console.Write($"{arr1[i]} ");
            //            arr2[j] = -1; // Because When we visit again it will be -1 So Not Equall
            //        }
            //    }
            //}
            #endregion
            #region 1.10 - Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target:
            //ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 7, 5 });
            //int targetSum;
            //do
            //{
            //    Console.Write("Please Enter A Target Sum You Want To Search: ");
            //} while (!int.TryParse(Console.ReadLine(), out targetSum));
            //bool found = false;
            //for (int i = 0; i < arrayList.Count; i++) // hold elements
            //{
            //    int Sum = 0; // Reset sum for each starting point
            //    for (int j = i; j < arrayList.Count; j++)
            //    {
            //        Sum += (int)arrayList[j]; // Add current element to sum
            //        if (Sum == targetSum)
            //        {
            //            found = true;
            //            ArrayList sumsub = new ArrayList();
            //            for (int k = i; k <= j; k++)
            //            {
            //                sumsub.Add(arrayList[k]); // Collect the sub list   
            //            }
            //            Console.WriteLine($"[{string.Join(", ", sumsub.ToArray())}]");
            //        }
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("Sorry, Not Founnd!");
            //}
            #endregion
            #region 1.11 - Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order:
            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            //int k;
            //do
            //{
            //    Console.Write("Please Enter K Value: ");
            //} while (!int.TryParse(Console.ReadLine(), out k));
            //ReverseFirstKElements(queue, k);
            //Printing_Queue(queue);
            #endregion
        }
    }
}