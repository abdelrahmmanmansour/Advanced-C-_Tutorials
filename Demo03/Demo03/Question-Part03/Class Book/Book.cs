using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Class_Book
{
    public class Book
    {
        #region Properties
        // Properties:
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicatioDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructosr
        // Constructors: 
        public Book(string ISBN, string Title, string[] Authors, DateTime PublicatioDate, decimal Price)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Authors = Authors;
            this.PublicatioDate = PublicatioDate;
            this.Price = Price;
        }
        #endregion

        #region Method
        // Method:
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"ISBN: {ISBN}");
            result.AppendLine($"Title: {Title}");
            if (Authors?.Length > 0)
            {
                result.AppendLine($"Authors: {string.Join(", ", Authors)}");
            }
            result.AppendLine($"PublicatioDate: {PublicatioDate.ToString("dd/MM/yyyy")}");
            result.AppendLine($"Price: {Price}");
            return result.ToString();
        }
        #endregion
    }
}
