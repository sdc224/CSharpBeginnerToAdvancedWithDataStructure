using System.Collections.Generic;

namespace CSharpAdvanced
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title = "ADO.NET Step by step", Price = 100},
                new Book{Title = "ASP.NET MVC", Price = 99.9f},
                new Book{Title = "ASP.NET Web API", Price = 130},
                new Book{Title = "C# Beginner Topics", Price = 300},
                new Book{Title = "C# Intermediate Topics", Price = 350},
                new Book{Title = "C# Advanced Topics", Price = 400}
            };
        }
    }
}