using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics

            /*var number = new Nullable<int>();
            Console.WriteLine(number.GetValueOrDefault());*/

            #endregion

            #region Delegates

            // Syntax
            // (access modifier) delegate (return type) (name of the delegate)(argument : class(maybe)); under class
            // .NET Framework has two Delegates
            // Action and Func
            // These two also have generic type

            /*var photoProcessor = new PhotoProcessor();

            var filter = new PhotoFilters();

            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEye;

            photoProcessor.Process("ABC", filterHandler);*/

            #endregion

            #region Lambda Expression

            // Syntax
            // args => expression
            // () => expression
            // => knows as Lambda Operator

            /*Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));*/

            #endregion

            #region Events and Delegates

            /*var video = new Video(){ Id = 1, Name = "Video 1" };
            var videoEncoder = new VideoEncoder();                                  // publisher
            var mailService = new MailService();                                    // subscriber
            var messageService = new MessageService();                              // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);*/

            #endregion

            #region Extension Methods

            /*const string post = "This is a very long blog post blah blah blah . . . ";
            var shorten = post.Shorten(5);
            Console.WriteLine(shorten);*/

            #endregion

            #region LINQ

            //var books = new BookRepository().GetBooks();

            // Without LINQ
            /*var cheapBooks = new List<Book>();
            
            foreach (var book in books)
            {
                if (book.Price < 200)
                    cheapBooks.Add(book);
            }*/

            // Note that Where is an extension method
            // Inside Where we have to give a predicate i.e. Func<> which is a delegate
            // So we can pass lambda expression


            // LINQ Query Operators
            /*var cheapBooks1 = from b in books
                where b.Price < 200
                orderby b.Title
                select b.Title;
            */

            // More readable is to specify all Linq in different lines

            // LINQ Extension Methods (same output as above)
            /*var cheapBooks = books
                .Where(b => b.Price < 200)
                .OrderBy(b => b.Price)
                .Select(b => b.Title);

            foreach (var cheapBook in cheapBooks)
                Console.WriteLine(cheapBook);
            //Console.WriteLine(cheapBook.Title + " " + cheapBook.Price);

            foreach (var cheap in cheapBooks1)
                Console.WriteLine(cheap);
            */
            /*var cheap = books.Skip(2).Take(2);

            foreach (var book in cheap)
            {
                Console.WriteLine(book.Title);
            }*/

            #endregion

            #region Nullable Types

            DateTime? date = null;
            var date2 = date ?? DateTime.Now;

            #endregion

            #region Dynamic

            /*dynamic name = "sdc";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;*/

            #endregion

            #region Exception Handling

            try
            {
                var streamReader = new StreamReader(@"d:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occurred!");
            }


            #endregion

            #region Asynchronous Programming

            // Use of async and await
            // In WPF, ASP.NET

            #endregion
        }

/*
        private static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing Red Eye...");
        }
*/
    }
}
