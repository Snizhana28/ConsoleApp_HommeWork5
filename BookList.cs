using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HommeWork5
{
    public class BookList
    {
        private List<Books> books = new List<Books>();
        public void Add(Books book)
        {
            books.Add(book);
        }
        public void Remove(Books book)
        {
            books.Remove(book);
        }
        public void Clear()
        {
            books.Clear();
        }
        public bool Contains(Books book)
        {
            return books.Contains(book);
        }
        public int Count => books.Count;
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                    return books[index];
                throw new IndexOutOfRangeException("Invalid index.");
            }
        }
        public void Print()
        {
            foreach (Books book in books)
            {
                Console.WriteLine("<----------------------------->");
                Console.WriteLine(book);
            }
            Console.WriteLine("<----------------------------->");
        }
    }
}
