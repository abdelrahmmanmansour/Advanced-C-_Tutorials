using Demo03.Compare_Two_Variables;
using Demo03.Delegate_EX01;
using Demo03.Delegate_EX02;
using Demo03.Delegate_EX03;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
namespace AdvancedC__Session_Three
{
    #region TO Make A Delegate
    // TO Make A Delegate:
    // Access Modifier => Public
    // delegate
    // return type of function i store address of it 
    // name of delegate
    // (paramter of function) 
    public delegate int DelegateFunc(string input);
    #endregion
    #region Notes About Delegate
    // Delegate => New DataType => Class 
    // Make from this class Reference or pointer Refer To Function or more[Same Signature] 
    #endregion
    #region Delegate To Print Numbers ODD Or Even In List
    // Delegate To Print Numbers ODD Or Even In List
    public delegate bool DelegateFuncNumbers<T>(T Element);
    #endregion
    internal class Program
    {
        #region To Print Array
        // To Print Array:
        public static void PrintArray<T>(T[] Arr)
        {
            Console.WriteLine();
            foreach (T item in Arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        #endregion
        #region To Print List
        // To Print List:
        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            foreach (T item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        #endregion
        #region Method To Print Numbers ODD Or Even In List
        // Method To Print ODD Numbers In List: 
        public static List<T> FindElement<T>(List<T> list, DelegateFuncNumbers<T> Ref)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (Ref.Invoke(list[i]))
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }
        #endregion
        #region Functions
        public static string Fun(int x) { return "x"; }
        public static void Fun01() { Console.WriteLine("Hello World"); }
        public static void Fun01(string x) { Console.WriteLine("Hello World"); }
        public static Action Print()
        {
            Action action = Print01;
            return action;
        }
        public static void Print01()
        {
            Console.WriteLine("Hello,Mansour");
        }
        #endregion

        static void Main(string[] args)
        {
            #region Delegate OverView
            // Delegate OverView:
            // C# Feature Using Paradiam Other OOP:

            // 1. Functional Programming:
            // 1.1 - Storing Functions in Variables
            // 1.2 - Passing in Parameter Of Function => Function as Parameter
            // 1.3 - Functions Returning Functions

            // 2. Event Driven Programming: Like Trigger in Database 
            #endregion
            #region Delegate EX01
            // Delegate EX01:
            // I Want To Make Variable Which Store Address Of This Function[StringFunction.CountUpperCase]
            // I Don't Learn Any DataType Store Address
            // So Make A Delegate in NameSpace
            DelegateFunc Upper = StringFunction.CountUpperCase;
            // Invoke Method: Have All Function that Upper => Address
            int upper = Upper.Invoke("Hello,World!");
            Console.WriteLine($"Upper : {upper}");

            DelegateFunc Lower = StringFunction.CountLowerCase;
            int lower = Lower.Invoke("Abdelrahman Mansour!");
            Console.WriteLine($"Lower : {lower}");
            #endregion
            #region Delegate EX02 Without Generic
            // Delegate EX02 Without Generic:
            int[] arr = { 1, 2, -1, -5, 0, 10, 60, 5, 4, 30, 7 };
            DelegateFuncCompare<int> Ascending = Compare.CompareGreater;
            DelegateFuncCompare<int> Descending = Compare.CompareLess;
            PrintArray(arr);
            Sorting_Algorithm.BubbleSort(arr, Ascending);
            PrintArray(arr);
            Sorting_Algorithm.BubbleSort(arr, Descending);
            PrintArray(arr);
            #endregion
            #region Delegate EX02 With Generic
            // Delegate EX02 With Generic:
            string[] Names = { "Ahmed", "Ali", "Mariam", "Mansour", "Amr", "Leqaa", "Reem" };
            PrintArray(Names);
            DelegateFuncCompare<string> less = Compare.CompareLess;
            Sorting_Algorithm.BubbleSort(Names, less);
            PrintArray(Names);
            DelegateFuncCompare<string> Greater = Compare.CompareGreater;
            Sorting_Algorithm.BubbleSort(Names, Greater);
            PrintArray(Names);
            #endregion
            #region Delegate EX03 Without Generic
            // Delegate EX03 Without Generic:
            List<int> list = Enumerable.Range(1, 100).ToList();
            DelegateFuncNumbers<int> Odd = ConditionFunction.OddList;
            List<int> resint = FindElement(list, Odd);
            PrintList(resint);
            DelegateFuncNumbers<int> Even = ConditionFunction.EvenList;
            List<int> reseven = FindElement(list, Even);
            PrintList(reseven);
            #endregion
            #region Delegate EX03 With Generic
            List<string> names = new List<string> { "Ahmed", "Ali", "Mariam", "Mansour", "Amr", "Leqaa", "Reem" };
            DelegateFuncNumbers<string> Greater4 = ConditionFunction.LengthGreater4;
            List<string> NamesG4 = FindElement(names, Greater4);
            PrintList(NamesG4);
            DelegateFuncNumbers<string> Less4 = ConditionFunction.LengthLess4;
            List<string> NamesL4 = FindElement(names, Less4);
            PrintList(NamesL4);
            #endregion
            #region Built-in Delegate
            // Built-in Delegate: 
            // 1. Predicate : 
            // Refer To Function => return bool && Take any DataType(only one parameter)
            Predicate<int> X = ConditionFunction.EvenList;
            // 2. Func:
            // Refer To Function not void => return anything + Take any DataType(0-16 parameter)
            Func<int, string> Y = Fun;
            string x = Y.Invoke(5);
            Console.WriteLine(x);
            // 3. Action:
            // Refer To Function void => Take any DataType(0-16 parameter)
            Action action = Fun01;
            action.Invoke();
            Action<string> action1 = Fun01;
            action1.Invoke("mansour");
            #endregion
            #region Anonymous Method && Lambda Expression
            // Anonymous Method && Lambda Expression: 
            // Anonymous Method: C# if i want to make function one time
            // Lambda Expression : C# Syntax Sugar to Anonymous Method
            //Func<int, bool> func = delegate (int x) { return x % 2 == 0; };
            Func<int, bool> func = x => x % 2 == 0;
            #endregion
            #region Var KeyWord
            // Var KeyWord: Detect DatatType Based on Value
            var input = 12;
            // input = "Hello"; invalid
            #endregion
            #region Function Return Function
            // Function Return Function: 
            Action action01 = Print();
            action01(); // or Print()();
            #endregion
            #region HashTables OverView
            // HashTables OverView: 
            // Array Based => key(unique),value
            #endregion
            #region Non-Generic HashTable
            // Non-Generic HashTable: 
            Hashtable PhoneBook = new Hashtable();
            PhoneBook.Add("Mansour", 1);
            PhoneBook.Add("Leqaa", 2);
            PhoneBook.Add("Mai", 3);
            PhoneBook.Add("Ahmed", 4);
            foreach (DictionaryEntry item in PhoneBook) // var == DictionaryEntry(constructor)
            {
                Console.WriteLine(item);
            }

            // Properties:
            Console.WriteLine($"Count : {PhoneBook.Count}");
            foreach (var item in PhoneBook.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in PhoneBook.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(PhoneBook["Mansour"]);
            PhoneBook["Mansour"] = 5; // Make value of mansour(key) => mona

            Console.WriteLine();
            foreach (var item in PhoneBook.Values)
            {
                Console.WriteLine(item);
            }
            // Note:
            // if i make key not exsit in hashtable then add it not exception
            PhoneBook["Ola"] = 5;
            foreach (DictionaryEntry item in PhoneBook) // var == DictionaryEntry(constructor)
            {
                Console.WriteLine(item);
            }

            // Methods:
            Console.WriteLine();
            Console.WriteLine();
            PhoneBook.Add("Mervat", 6);
            foreach (DictionaryEntry item in PhoneBook) // var == DictionaryEntry(constructor)
            {
                Console.WriteLine(item);
            }

            //PhoneBook.Clear();
            //Console.WriteLine($"Count : {PhoneBook.Count}");
            //foreach (DictionaryEntry item in PhoneBook) // var == DictionaryEntry(constructor)
            //{
            //    Console.WriteLine(item);
            //}

            PhoneBook.Remove("Ola");
            foreach (DictionaryEntry item in PhoneBook) // var == DictionaryEntry(constructor)
            {
                Console.WriteLine(item);
            }

            var Flag = PhoneBook.Contains("mai"); // Case Sensitve
            Console.WriteLine(Flag);

            var Flag01 = PhoneBook.ContainsKey("Mai"); // Case Sensitve
            Console.WriteLine(Flag01);

            var Flag02 = PhoneBook.ContainsValue(8); // Case Sensitve
            Console.WriteLine(Flag02);


            #endregion
            #region Generic Dictionary
            // Generic Dictionary:
            // Version Generic of HashTable
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Messi");
            dic.Add(2, "Salah");
            dic.Add(3, "CR7");
            dic.Add(4, "Pogba");
            foreach (KeyValuePair<int, string> item in dic) // var = KeyValuePair<int,string>
            {
                Console.WriteLine(item);
            }
            var Flag03 = dic.Remove(1, out string value); //  Remove it
            Console.WriteLine(Flag03);
            Console.WriteLine(value); // Messi
            foreach (KeyValuePair<int, string> item in dic) // var = KeyValuePair<int,string>
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Generic HashSet
            // Generic HashSet:
            // Value => Null
            // have key only
            HashSet<string> NNames = new HashSet<string>();
            NNames.Add("Zizo");
            NNames.Add("Ashour");
            NNames.Add("ola");
            NNames.Add("Zizo");
            foreach (var item in NNames)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}