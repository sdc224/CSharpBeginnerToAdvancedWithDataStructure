// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSharpAdvanced
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
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

            /*try
            {
                var streamReader = new StreamReader(@"d:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occurred!");
            }*/

            #endregion

            #region Asynchronous Programming

            // Use of async and await
            // In WPF, ASP.NET

            #endregion

            #region Parallel Programming in .NET

            #region Task Programming

            // Part 1
            /*Task.Factory.StartNew(() => Write('.'));

            var task = new Task(() => Write('?'));
            task.Start();

            Write('-');*/

            // Part 2
            // You can use an object also
            /*var task = new Task(Write, "hello");
            task.Start();

            Task.Factory.StartNew(Write, 123);*/

            // Part 3
            /*var text1 = "testing";
            var text2 = "this";
            var task1 = new Task<int>(TextLength, text1);
            task1.Start();

            var task2 = Task.Factory.StartNew(TextLength, text2);

            Console.WriteLine($"Length of '{text1}' is {task1.Result}");
            Console.WriteLine($"Length of '{text2}' is {task2.Result}");*/

            // Part 4
            // Cancelling of a Task
            
            /*var cts = new CancellationTokenSource();
            var token = cts.Token;*/
            
            // Part 4 a.
            /*var t = new Task(
                () =>
                    {
                        var i = 0;
                        while (true)
                        {
                            if (token.IsCancellationRequested)
                            {
                                break;
                            }

                            Console.WriteLine($"{i++}\t");
                        }
                    },
                token);

            t.Start();

            Console.ReadKey();
            cts.Cancel();
             */

            // Part 4 b. Using Exceptions
            /*var t = new Task(
                () =>
                    {
                        var i = 0;
                        while (true)
                        {
                            if (token.IsCancellationRequested)
                            {
                                throw new OperationCanceledException();
                            }

                            Console.WriteLine($"{i++}\t");
                        }
                    },
                token);

            t.Start();*/

            // Part 4 c. Most Canonical Way(TPL prescribed)
            /*var t = new Task(
                () =>
                    {
                        var i = 0;
                        while (true)
                        {
                            token.ThrowIfCancellationRequested();
                            Console.WriteLine($"{i++}\t");
                        }
                    },
                token);

            t.Start();*/

            // Part 5
            // Message on Cancellation
            /*token.Register(() => Console.WriteLine("Cancellation requested!"));

            var t = new Task(
                () =>
                    {
                        var i = 0;
                        while (true)
                        {
                            token.ThrowIfCancellationRequested();
                            Console.WriteLine($"{i++}\t");
                        }
                    },
                token);

            t.Start();

            Task.Factory.StartNew(
                () =>
                    {
                        token.WaitHandle.WaitOne();
                        Console.WriteLine("Wait handle has been released! Cancellation has been requested!");
                    });

            Console.ReadKey();
            cts.Cancel();*/

            // Part 6
            // More than one Cancellation Source
            var planned = new CancellationTokenSource();
            var preventative = new CancellationTokenSource();
            var emergency = new CancellationTokenSource();

            var paranoid = CancellationTokenSource.CreateLinkedTokenSource(
                planned.Token,
                preventative.Token,
                emergency.Token);

            var t = new Task(
                () =>
                    {
                        var i = 0;
                        while (true)
                        {
                            paranoid.Token.ThrowIfCancellationRequested();
                            Console.WriteLine($"{i++}\t");
                        }
                    },
                paranoid.Token);

            t.Start();

            Console.ReadKey();
            preventative.Cancel();

            #endregion

            #endregion
        }

        public static void Write(char c)
        {
            var i = 1000;

            while (i-- > 0)
            {
                Console.Write(c);
            }
        }

        public static void Write(object o)
        {
            var i = 1000;

            while (i-- > 0)
            {
                Console.Write(o);
            }
        }

        public static int TextLength(object o)
        {
            Console.WriteLine($"\nTask with id {Task.CurrentId} processing object {o}...");
            return o.ToString().Length;
        }

/*
        private static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing Red Eye...");
        }
*/
    }
}
