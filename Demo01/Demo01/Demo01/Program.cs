using Demo01.Employee_Linear_Search;
using Demo01.Generic_Swapping_Example;
using Demo01.Struct_Point;
using System;
using System.Collections;
namespace Demo01    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Swapping Example
            // Generic Swapping Example:
            // Generic : C# Feature
            // Allow Creating(Classes,Structures,Interfaces,Methods,Properties With Any Data Type)
            Console.WriteLine("All These Not Generic Methods");
            int A = 10, B = 20;
            Console.WriteLine("**** Before Swapping ****");
            Console.WriteLine($"A: {A} , B: {B}");
            Helper.Swap_Values(ref A, ref B);
            Console.WriteLine("**** After Swapping ****");
            Console.WriteLine($"A: {A} , B: {B}");
            // If We Want To Swap Values Of Other Data Types
            // So We Need To Create Another Method(Overloading): Not Best Practice
            Point point1 = new Point(10, 20);
            Point point2 = new Point(30, 40);
            Console.WriteLine("**** Before Swapping ****");
            Console.WriteLine($"Point1: {point1} , Point2: {point2}");
            Helper.Swap_Values(ref point1, ref point2);
            Console.WriteLine("**** After Swapping ****");
            Console.WriteLine($"Point1: {point1} , Point2: {point2}");
            Console.WriteLine("***************************************");
            Console.WriteLine("All These Generic Methods");
            int X = 10, Y = 20;
            Console.WriteLine("**** Before Swapping ****");
            Console.WriteLine($"X: {X} , Y: {Y}");
            Helper.Swap_Values(ref X, ref Y);
            Console.WriteLine("**** After Swapping ****");
            Console.WriteLine($"X: {X} , Y: {Y}");
            // If We Want To Swap Values Of Other Data Types
            // So We Need To Create Another Method(Overloading): Not Best Practice
            Point point01 = new Point(50, 100);
            Point point02 = new Point(60, 200);
            Console.WriteLine("**** Before Swapping ****");
            Console.WriteLine($"Point1: {point01} , Point2: {point02}");
            Helper.Swap_Values(ref point01, ref point02);
            Console.WriteLine("**** After Swapping ****");
            Console.WriteLine($"Point1: {point01} , Point2: {point02}");
            Console.WriteLine("***************************************");
            #endregion
            #region Generic Linear Search Example
            // Generic Linear Search Example:
            // Note : All Data Types Support Equals Method
            // Note: Not All Data Types Support == Operator
            // Note: Struct Data Types Do Not Support == Operator
            // Note: Class Data Types Support == Operator(Address)
            // For Example: String, Int, Double, Char, etc. Support == Operator
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine(Helper.Linear_Search(arr, 50)); // 4

            Employee Emp01 = new Employee() { Id = 1, Name = "Mansour", Age = 30, Salary = 50000 };
            Employee Emp02 = new Employee() { Id = 2, Name = "Ahmed", Age = 40, Salary = 4000 };
            Employee Emp03 = new Employee() { Id = 3, Name = "Sara", Age = 50, Salary = 6000 };
            Employee Emp04 = new Employee() { Id = 4, Name = "Moa", Age = 60, Salary = 1500 };
            Employee Emp05 = new Employee() { Id = 1, Name = "Mansour", Age = 30, Salary = 50000 };
            Employee[] employees = { Emp01, Emp02, Emp03, Emp04 };
            Console.WriteLine(Helper.Linear_Search(employees, Emp03));
            Console.WriteLine(Helper.Linear_Search(employees, new Employee() { Name = "Sara" }, new Employee()));
            #endregion
            #region Equality in Class and Struct
            // Equality in Class and Struct:
            // Class && Struct Have Equals Method (Which Iherit From Object Class)
            // Class =>  Compare By Reference(Address => GetHashCode)
            // Struct => Compare By Data(Values)
            // Where Employee Is Class: Address
            Console.WriteLine($"Emp01: {Emp01.GetHashCode()} Emp02: {Emp02.GetHashCode()}");
            if (Emp01.Equals(Emp02)) Console.WriteLine("Emp01 == Emp02");
            else Console.WriteLine("Emp01 != Emp02");
            // Where Employee Is Struct: Values
            if (Emp01.Equals(Emp05))
            {
                Console.WriteLine("Emp01 == Emp05");
            }
            else
            {
                Console.WriteLine("Emp01 != Emp05");
            }
            #endregion
            #region Generic Bubble Sort Example
            // Generic Bubble Sort Example:
            // We Want To Sort An Array:
            int[] numbers = { 5, 3, 8, 4, 2 };
            Console.Write("Before Sorting: ");
            Helper.Print_Array(numbers);
            Console.Write("After Sorting: ");
            Helper.Bubble_Sort(numbers);
            Helper.Print_Array(numbers);
            Point[] points =
            {
                new Point(5, 3),
                new Point(8, 4),
                new Point(2, 1),
                new Point(6, 7)
            };
            Console.Write("Before Sorting: ");
            Helper.Print_Array(points);
            Console.Write("After Sorting: ");
            Helper.Bubble_Sort(points);
            Helper.Print_Array(points);
            #endregion
            #region Is And As Operators
            // Is And As Operators:
            Point point = new Point(10, 20);
            Point point3 = new Point(30, 40);
            if (point.CompareTo(point3) > 0)
            {
                Console.WriteLine("point is greater than point3");
            }
            else
            {
                Console.WriteLine("point is not greater than point3");
            }
            // if i put this point.CompareTo(null) > 0
            // if i put this point.CompareTo(anything other point ) > 0
            if (point.CompareTo(point3) > 0)
            {
                Console.WriteLine("point is greater than point3");
            }
            else
            {
                Console.WriteLine("point is not greater than point3");
            }
            #endregion
            #region IComparable Vs Generic IComparable
            // IComparable Vs Generic IComparable:
            // Generic IComparable: IComparable<T>(handle Casting) 
            // IComparable: IComparable(need to cast)
            #endregion
            #region Built-in Interface Generic IEquatable<T>
            // Built-in Interface Generic IEquatable<T>:
            // Override Equals Method: handle Casting 
            #endregion
            #region Built-in Interface Generic IEqualityComparer<T>
            // Built-in Interface Generic IEqualityComparer<T>:
            //  if i want to search spesific attribute(age,name)
            // Have Two Signature Of Methods:
            // 1. Equals(T x, T y): Compare Two Objects
            // 2. GetHashCode(T obj): Get Hash Code Of Object 
            #endregion
            #region IComparer With Bubble Sort
            // IComparer With Bubble Sort:
            // if you want to sort by spesific attribute(age,name) 
            Helper.Print_Array(employees);
            Helper.Bubble_Sort(employees, new Employee());
            Helper.Print_Array(employees);
            #endregion
            #region Generic Constraints
            // Generic Constraints: 
            // 1. Primary Constraints:[0,1]
            // where T : class or struct or enum or not null
            // 2. Secondary Constraints:[0,more]
            // where T Implement: IComparable<T> or IEquatable<T> or IEqualityComparer<T>
            // 3. Constructor Constraints:
            // new() : T must have a parameterless constructor
            #endregion
        }
    }
}
