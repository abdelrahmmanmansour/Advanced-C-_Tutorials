using Demo02.Employees;
using System.Collections;
using System.Threading.Channels;

namespace AdvancedC__Session_Two
{
    internal class Program
    {
        #region Printing Items In ArrayList
        public static void Printing_ArrayList(ArrayList arrayList)
        {
            Console.WriteLine();
            Console.Write("Items Are: ");
            foreach (int Item in arrayList)
            {
                Console.Write($"{Item} ");
            }
            Console.WriteLine();
        }
        #endregion
        #region Printing Items In List
        // Printing Items In List:
        public static void Printing_List<T>(List<T> values)
        {
            Console.WriteLine();
            Console.Write("Items Are: ");
            foreach (T item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion
        #region Printing Items In LinkedList
        // Printing Items In LinkedList:
        public static void Printing_LinkedList(LinkedList<int> linkedList)
        {
            Console.WriteLine();
            Console.Write("Null -> ");
            foreach (int item in linkedList)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write(" Null");
            Console.WriteLine();
        }
        #endregion
        #region Printing Items In Stack
        // Printing Items In Stack:
        public static void Printing_Stack(Stack<int> stack)
        {
            Console.WriteLine();
            Console.WriteLine("Items Are: ");
            foreach (int item in stack)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion
        #region Printing Items In Queue
        // Printing Items In Queue:
        public static void Printing_Queue(Queue<int> queue)
        {
            Console.WriteLine();
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
            #region What is A Data Structure ?
            // What is A Data Structure ?
            // The Way of Organizing and Storing Data To Enable Efficient Access and Modification.
            #endregion
            #region What is A Collections ?
            // What is A Collections ? 
            // Built-in Data Structures In C#
            // Like Arrays, Lists, Queues, Stacks
            // Kinds Of Collections:
            // 1. Lists
            // 2. Hash Tables

            // 1. Lists:
            // Non-Generic List =>  ArrayList, Stack, Queue
            // Generic List =>  List<T>, Stack<T>, Queue<T> , LinkedList<T>

            // 2. Hash Tables:
            // Non-Generic Hash Table => Hashtable
            // Generic Hash Table => Dictionary<TKey, TValue>, SortedDictionary<TKey, TValue>
            #endregion
            #region Deep In Data Structures
            // Deep In Data Structures:
            // Array Based [Linear Data Structures]: أنا عارف اى هو القيمة التاالية
            // Elements Access By Index + Contiguous Memory(محطوطين جمب بعض)
            // Equation: Index = Current Address + (Number Of Bytes * Index)


            // Node Based [Linear Data Structures or Non-Linear Data Structures]: 
            // أنا مش عارف اى هو القيمة التاالية
            // Non-Contiguous Memory( مش محطوطين جمب بعض)
            // Elements Are Nodes
            // Any Node Has : (Value + Address Of Next Node) And The Last Node => Null 
            // The First Element Is Called (Head , Front , Top , First)
            // The Last Element Is Called (Tail , Last)


            // Hash Table : Array Based Data Structure  O(1) Access Time
            // Has Key(Unique) And Value
            #endregion
            #region Non-Generic List [ArrayList]
            // Non-Generic List [ArrayList]:
            // Like Array
            // ArrayList => Array Based Data Structure
            // Array : Fixed Size
            // ArrayList : Dynamic Size
            int[] array = new int[10];
            Console.WriteLine(array[2]);  // 3

            // Built-in Class
            // Count(Size) == Number Of Elements
            // Capacity == Space Allocated In Memory + Default Capacity is 4 + When You Add Elements It Will be *2
            // Any Non-Generic => Implements ICollection Interface(Container)
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Count : {arrayList.Count}  Capacity: {arrayList.Capacity}");
            arrayList.Add(1);

            // Properties:
            Console.WriteLine($"Count : {arrayList.Count} ,  Capacity: {arrayList.Capacity}");
            Console.WriteLine($"IsFixedSize : {arrayList.IsFixedSize} ,  IsReadOnly : {arrayList.IsReadOnly}");
            Console.WriteLine(arrayList[0]);
            // Or I Can Set The Value
            arrayList[0] = 2;
            Console.WriteLine(arrayList[0]);

            // Methods:
            arrayList.Add(3);
            arrayList.Add(4);
            Printing_ArrayList(arrayList);
            // AddRange Method => Add Multiple Items
            arrayList.AddRange(new int[] { 5, 6, 7, 8 });
            Printing_ArrayList(arrayList);
            // BinarySearch Method => Search For Item
            int Index = arrayList.BinarySearch(2);
            Console.WriteLine(Index);
            // BinarySearch Method => Search For Item in Employee Class
            Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 5000 };
            Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 23, Salary = 6000 };
            Employee E03 = new Employee() { Id = 3, Name = "Mariam", Age = 24, Salary = 7000 };
            Employee E04 = new Employee() { Id = 4, Name = "Omar", Age = 25, Salary = 8000 };
            ArrayList employeeList = new ArrayList();
            Console.WriteLine($"Count : {employeeList.Count} ,  Capacity: {employeeList.Capacity}");
            employeeList.AddRange(new Employee[] { E01, E02, E03, E04 });
            Console.WriteLine($"Count : {employeeList.Count} ,  Capacity: {employeeList.Capacity}");
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine($"{emp}");
            }
            int Index01 = employeeList.BinarySearch(E02);
            Console.WriteLine(Index01);

            Index01 = employeeList.BinarySearch(new Employee() { Age = 22 }, new EmployeeComparer());
            Console.WriteLine(Index01);

            Index01 = employeeList.BinarySearch(0, 2, new Employee() { Age = 23 }, new EmployeeComparer());
            Console.WriteLine(Index01);

            // Clear Method => Clear All Items
            //employeeList.Clear();
            //Console.WriteLine($"Count : {employeeList.Count} ,  Capacity: {employeeList.Capacity}");

            // Contains Method => Check If Item Exists
            bool IS_Exsist = arrayList.Contains(8);
            Console.WriteLine(IS_Exsist);

            // CopyTo Method => Copy Items To Array 
            arrayList.CopyTo(1, array, 3, 4);
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            // GetRange Method => Get Range Of Items    
            ArrayList arrayList1 = arrayList.GetRange(0, 3);
            Printing_ArrayList(arrayList1);  // Items Are: 2 3 4

            // IndexOf Method => Get Index Of Item  
            int output = arrayList.IndexOf(5);
            Console.WriteLine(output);
            output = arrayList.IndexOf(5, 2, 4);
            Console.WriteLine(output);

            // Insert Method => Insert Item At Index
            arrayList.Insert(0, 9);
            Printing_ArrayList(arrayList);
            arrayList.InsertRange(0, new int[] { 10, 20, 30 });
            Printing_ArrayList(arrayList);

            // LastIndexOf Method => Get Last Index Of Item
            int lastIndex = arrayList.LastIndexOf(9);
            Console.WriteLine(lastIndex);

            // Remove Method => Remove Item
            arrayList.Remove(10);
            Printing_ArrayList(arrayList);

            // RemoveAt Method => Remove Item At Index  
            arrayList.RemoveAt(0);
            Printing_ArrayList(arrayList);

            // RemoveRange Method => Remove Range Of Items  
            arrayList.RemoveRange(0, 3);  // Remove 3 Items From Index 0
            Printing_ArrayList(arrayList);

            // Reverse Method => Reverse Items
            arrayList.Reverse();
            Printing_ArrayList(arrayList);

            // Set Range Method => Set Range Of Items
            arrayList.SetRange(0, new int[] { 100, 200, 300 }); // Set Items From Index 0
            Printing_ArrayList(arrayList);

            // Sort Method => Sort Items    
            arrayList.Sort();
            Printing_ArrayList(arrayList);

            employeeList.Sort(new EmployeeComparer());
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine($"{emp}");
            }
            Console.WriteLine($"Count : {employeeList.Count} ,  Capacity: {employeeList.Capacity}");
            // TrimToSize Method => Trim Capacity To Count
            arrayList.TrimToSize();
            Console.WriteLine($"Count : {employeeList.Count} ,  Capacity: {employeeList.Capacity}");
            #endregion
            #region Problem With ArrayList
            // Problem With ArrayList Or Any Non-Generic Collection:
            // Casting
            #endregion
            #region Generic List[List]
            // Generic List[List]:
            // Array Based Data Structure 
            // Generic Version Of ArrayList + Dynamic Size
            List<int> list = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            Printing_List(list);

            // Properties: Same As ArrayList

            // Methods:
            list.Add(6);
            Printing_List(list);
            list.AddRange(new int[] { 7, 8, 9 });
            Printing_List(list);
            int i = list.BinarySearch(8);
            Console.WriteLine(i);
            List<Employee> employees = new List<Employee> { E01, E02, E03, E04 };
            i = employees.BinarySearch(E01, new EmployeeGenenreicComparer());
            Console.WriteLine(i);
            i = employees.BinarySearch(0, 2, E02, new EmployeeGenenreicComparer());
            Console.WriteLine(i);
            list.EnsureCapacity(20);
            #endregion
            #region Generic List[LinkedList]
            // Generic List[LinkedList]:
            // Node Based Data Structure
            // Internaly Uses Doubly Linked List(prev,value,next)
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            Printing_LinkedList(linkedList);
            linkedList.AddLast(5);
            LinkedListNode<int> node = new LinkedListNode<int>(6);
            LinkedListNode<int> node1 = new LinkedListNode<int>(8);
            linkedList.AddLast(node);
            Printing_LinkedList(linkedList);
            linkedList.AddAfter(node, 7);
            Printing_LinkedList(linkedList);
            linkedList.AddBefore(node, node1);
            Printing_LinkedList(linkedList);
            linkedList.Remove(2);
            Printing_LinkedList(linkedList);
            linkedList.RemoveFirst();
            Printing_LinkedList(linkedList);
            linkedList.Remove(linkedList.Last.Value);
            Printing_LinkedList(linkedList);
            #endregion
            #region Generic List[Stack]
            // Generic List[Stack]: 
            // Array Based Data Structure
            // Last In First Out (LIFO)
            // Remove From Top
            // Add To Top
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            int top = stack.Peek(); // Get Top Item 
            Console.WriteLine(top);
            Printing_Stack(stack);
            stack.Pop(); // Remove Top Item
            Printing_Stack(stack);
            bool Flag = stack.TryPeek(out int topItem); // Try Get Top Item
            Console.WriteLine(Flag);
            bool Flag1 = stack.TryPop(out int poppedItem); // Try Remove Top Item   
            Console.WriteLine(Flag1);
            #endregion
            #region Generic List[Queue]
            // Generic List[Queue]: 
            // Array Based Data Structure
            // First In First Out (FIFO)
            // Remove From Front
            // Add To Back
            Queue<int> queue = new Queue<int>(4);
            queue.Enqueue(1); // Add Item To Queue  
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Printing_Queue(queue);
            queue.Dequeue(); // Remove First Item
            Printing_Queue(queue);
            bool Flag02 = queue.TryPeek(out int frontItem); // Try Get First Item
            Console.WriteLine(Flag02);
            queue.TryDequeue(out int dequeuedItem); // Try Remove First Item
            Printing_Queue(queue);
            #endregion
        }
    }
}