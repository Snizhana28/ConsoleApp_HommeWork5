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
        public override string ToString()
        {
            string result = "";
            foreach (var item in books)
            {
                result += item.ToString() + "\n";
            }
            return result;
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

    }
}
