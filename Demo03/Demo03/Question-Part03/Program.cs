using Question_Part03.Class_Book;

namespace Question_Part03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 03:

            // Part 01:

            #region Complete The First Code[Class Book]
            // The First Code[Class Book]:
            //string[] Authors = { "Ahmed", "Ayman" };
            //Book book = new Book("3020-9211-1119", "C#", Authors, new DateTime(2002, 9, 21), 12.5m);
            //Console.WriteLine(book);
            //Console.WriteLine("========================");
            //Console.WriteLine();
            #endregion

            #region Complete The Second Code[Class Book Functions]
            // The Second Code[Class Book Functions]:
            //string[] Authores = { "Leqaa", "ola" };
            //Book b = new Book("Reem", "Python", Authores, new DateTime(2002, 9, 21), 12.5m);
            //Console.WriteLine($"The Title Of Book: {BookFunctions.Get_Title(b)}");

            //Console.Write($"The Authors Of Book: {BookFunctions.Get_Authors(b)}");

            //Console.WriteLine($"The Price Of Book: {BookFunctions.Get_Price(b)}");
            //Console.WriteLine("========================");
            //Console.WriteLine();
            #endregion

            List<Book> blist = new List<Book>
            {
                new Book("3070-921120-111", "C#", new string[] { "Ahmed", "Ayman" }, new DateTime(2023, 5, 1), 100m),
                new Book("3080-921120-111", "Algorithm", new string[] { "Leqaa" }, new DateTime(2024, 1, 10), 150m)
            };


            #region accept BookFunctions Methods using following cases: 
            // a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class:

            //Library_Engine.ProcessBooks(blist, BookFunctions.Get_Title);
            //Console.WriteLine("==============");
            //Console.WriteLine();
            //Library_Engine.ProcessBooks(blist, BookFunctions.Get_Authors);
            //Console.WriteLine("==============");
            //Console.WriteLine();
            //Library_Engine.ProcessBooks(blist, BookFunctions.Get_Price);
            //Console.WriteLine("==============");
            //Console.WriteLine();


            // b) Use the Proper build in delegate.:

            //Library_Engine.ProcessBooks(blist, BookFunctions.Get_Title);
            //Console.WriteLine("==============");
            //Console.WriteLine();
            //Library_Engine.ProcessBooks(blist, BookFunctions.Get_Authors);
            //Console.WriteLine("==============");
            //Console.WriteLine();
            //Library_Engine.ProcessBooks(blist, BookFunctions.Get_Price);
            //Console.WriteLine("==============");
            //Console.WriteLine();


            // c) Anonymous Method (GetISBN):
            //Library_Engine.ProcessBooks(blist, delegate (Book book) { return book.ISBN; });


            // d) Lambda Expression (GetPublicationDate):
            //Library_Engine.ProcessBooks(blist, b => b.PublicatioDate.ToString("dd/MM/yyyy"));

            #endregion
        }
    }
}

