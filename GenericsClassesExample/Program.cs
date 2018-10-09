using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problems that the generic list is the redundant information.
            // and avoid the penalty performance in the program.

            var book = new Book { Id = 1, Title = "Generic sample", Autor = "Mosh" };

            var books = new BookList();
            books.Add(book);

            var numbers = new List<int>();
            numbers.Add(10);

            var genericBookList = new GenericList<Book>();
            genericBookList.Add(book);

            var genericNumbers = new GenericList<int>();
            genericNumbers.Add(5);
                      
        }
    }
}
