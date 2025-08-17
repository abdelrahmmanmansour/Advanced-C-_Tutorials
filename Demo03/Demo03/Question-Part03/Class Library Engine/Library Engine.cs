using Question_Part03.Class_Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Class_Library_Engine
{
    #region User Defined Delegate
    public delegate string DelegateUserBookFunctions(Book book);
    #endregion
    internal static class Library_Engine
    {
        #region This Version Accept User Defined Delegate
        //public static void ProcessBooks(List<Book> blist, DelegateUserBookFunctions Fptr)
        //{
        //    foreach (Book book in blist)
        //    {
        //        Console.WriteLine(Fptr.Invoke(book));
        //    }
        //}
        #endregion

        #region This Version Accept Func<Book, string> Buit-in
        public static void ProcessBooks(List<Book> blist, Func<Book, string> Fptr)
        {
            foreach (Book book in blist)
            {
                Console.WriteLine(Fptr.Invoke(book));
            }
        }
        #endregion

    }
}
