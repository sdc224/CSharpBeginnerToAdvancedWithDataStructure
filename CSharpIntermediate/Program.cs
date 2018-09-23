namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Use of Params

            /*var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine(calc.Add(1, 2, 3));*/

            #endregion

            #region Use of readonly and Constructors definitions

            /*var customer = new Customer(1);
            
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);*/

            #endregion

            #region Use of properties and private set

            /*var person = new Person(new DateTime(1982, 1, 1));

            Console.WriteLine("You are {0} years, {1} months and {2} days old", person.Age.Year, person.Age.Month, person.Age.Day);*/

            #endregion

            #region Use of Indexers

            /*var cookie = new HttpCookie {["name"] = "SDC"};
            Console.WriteLine(cookie["name"]);*/

            #endregion

            #region Stopwatch exercise

            /*var stopwatch = new Stopwatch();

            while(true)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine("Duration: " + stopwatch.Duration);
                Console.WriteLine("Press enter to start the stopwatch one more time, type e to exit");

                var x = Console.ReadLine();

                if (x.Contains("e"))
                    break;
            }*/

            #endregion

            #region StackOverflow Post exercise

            /*var post = new Post
            {
                Title = "C Sharp",
                Description = "C Sharp Intermediate",
                CreatedTime = DateTime.Now
            };

            while (true)
            {
                Console.WriteLine("Press u for upvote, d for downvote, m for display vote value and e for exit");
                var x = Console.ReadLine();

                if(x.Contains("u"))
                    post.Upvote();

                if (x.Contains("d"))
                    post.Downvote();

                if (x.Contains("m"))
                    Console.WriteLine("Post: " + post.Title + "\nDescription: " + post.Description + "\nCreated on: " + post.CreatedTime.ToShortDateString() + "\nVote value is: " + post.GetVoteValue());

                if (x.Contains("e"))
                    break;
            }*/

            #endregion

            #region Boxing and Unboxing

            /*var list = new ArrayList {1, "SDC", DateTime.Today};
            var number = (int) list[1];*/

            #endregion

            #region Stack exercise

            /*var stack = new Stack();
            stack.Push(1);
            stack.Push("sdc");
            stack.Push(DateTime.Today);
            stack.Push(2);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.TopElement());
            stack.Clear();
            */

            #endregion

            #region Polymorphism

            /*var shapes = new List<Shape> {new Circle(), new Rectangle()};

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);*/

            #endregion

            #region DbConnection Exercise   

            /*var sqlConnection = new SqlConnection("ABC") {Timeout = new TimeSpan()};
            
            var dbCommand = new DbCommand(sqlConnection, "T-SQL");
            dbCommand.Execute();*/

            #endregion

            #region Interfaces

            /*var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);*/

            #endregion

            #region Interface Extensibility

            /*var dbMigrator = new DbMigrator(new FileLogger("D://log.txt"));
            dbMigrator.Migrate();*/

            #endregion

            #region Interfaces and Polymorphism

            /*var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());*/

            #endregion

            #region Workflow Engine Exercise

            /*var workFlow = new WorkFlow();
            workFlow.Add(new VideoUpload());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);*/

            #endregion
        }
    }
}
