using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Books
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private string Year { get; set; }
        private string Price { get; set; }
        private string Genre { get; set; }
        private string ISBN { get; set; }
        private string Publisher { get; set; }
        private string PageCount { get; set; }
        public Books(string title, string author, string year, string genre, string isbn, string publisher, string pageCount, string price)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            ISBN = isbn;
            Publisher = publisher;
            PageCount = pageCount;
            Price = price;
        }
        public string GetDescription()
        {
            return $"\"{Title}\"-{Author}-{Year}-{Genre}-{ISBN}-{Publisher}-{PageCount}бр.-{Price}лв.";
        }
    }
}
