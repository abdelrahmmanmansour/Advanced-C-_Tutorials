using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01.Task_two_MultiBox
{
    internal class MultiBox<T>
    {
        #region Properties to hold items, count of items, and capacity
        // Properties to hold items, count of items, and capacity:
        public List<T> Items { get; set; }
        public int Count_Item { get; set; }
        public int Capacity { get; set; }
        #endregion

        #region Constructor to initialize the MultiBox with a specified capacity
        // Constructor to initialize the MultiBox with a specified capacity:
        public MultiBox(int Capacity)
        {
            this.Capacity = Capacity;
            Items = new List<T>(Capacity);
            Count_Item = 0;
        }
        #endregion

        #region Methods to get the count of items
        // Methods to get the count of items:
        public int GetCount()
        {
            Console.Write("The Numbers Of Items In Box: ");
            return Count_Item;
        }
        #endregion

        #region Methods to check if the MultiBox is empty
        // Methods to check if the MultiBox is empty:
        public bool IsEmpty()
        {
            return Count_Item == 0;
        }
        #endregion

        #region Methods to check if the MultiBox is full
        // Methods to check if the MultiBox is full:
        public bool IsFull()
        {
            return Count_Item >= Capacity;
        }
        #endregion

        #region Methods to insert an item into the MultiBox
        // Methods to insert an item into the MultiBox:
        public void Insert_Item(T item)
        {
            if (IsFull())
            {
                return; // To prevent adding more items if the MultiBox is full
            }
            Items.Add(item); // Add the item to the list (Built in Method)
            Count_Item++;
        }
        #endregion

        #region Methods to retrieve all items in the MultiBox
        // Methods to retrieve all items in the MultiBox:
        public void GetAllItems()
        {
            if (Items is not null && Items.Count > 0)
            {
                Console.Write("The Items are: ");
                foreach (var item in Items)
                {
                    Console.Write($"{item} ");
                }
            }
            else
            {
                Console.WriteLine("No Items in the MultiBox");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
