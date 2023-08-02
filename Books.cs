using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HommeWork5
{
    public class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }

        public Books()
        {
        }
        public Books(string name, string author, string genre, int year, int pages, int price)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
            Pages = pages;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, \nAuthor: {Author}, \nGenre: {Genre}, \nYear: {Year}, \nPages: {Pages}, \nPrice: {Price}";
        }
    }
}
