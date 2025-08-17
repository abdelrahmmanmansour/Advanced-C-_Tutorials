using System;
using Question_Part03.Class_Book;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Class_Book_Functions
{
    internal static class BookFunctions
    {
        #region Method To Get Title Of Book
        // Method To Get Title Of Book:
        public static string Get_Title(Book book)
        {
            return book.Title;
        }
        #endregion

        #region Method To Get Authors Of Book
        // Method To Get Authors Of Book:
        public static string Get_Authors(Book book)
        {
            StringBuilder StringBuilder = new StringBuilder();
            if (book.Authors?.Length > 0)
            {
                StringBuilder.AppendLine(string.Join(", ", book.Authors));
            }
            return StringBuilder.ToString();
        }
        #endregion

        #region Method To Get Price Of Book
        // Method To Get Price Of Book: 
        public static string Get_Price(Book book)
        {
            return book.Price.ToString();
        }
        #endregion
    }
}
