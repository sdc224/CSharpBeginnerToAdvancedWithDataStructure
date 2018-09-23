using System;
using System.IO;

namespace CSharpBeginner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Practice

            // DateTime immutable string
            /*var dateTime = new DateTime(2015, 1, 1);
            var addYears = dateTime.AddYears(1);
            Console.WriteLine(dateTime.Year + " " + addYears.Year);*/

            /*const string fare = "1234567";
            var parsed = decimal.Parse(fare, CultureInfo.InvariantCulture);
            var hindi = new CultureInfo("hi-IN");
            var text = string.Format(hindi, "{0:c}", parsed);
            Console.WriteLine(text);
             const string text = "What is Lorem Ipsum ?\n" +
               "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
               "Why do we use it ?\n" +
               "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more - or - less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose(injected humour and the like).\n";
               
               var summary = StringUtility.SummarizeTextTool(text, 150);
               Console.WriteLine(summary);
             */

            //File.Copy(@"D:/ek poloker ektu dekha.mp3", @"D:/pooja/ek poloker ektu dekha.mp3");
            //File.Delete(@"D:/pooja/ek poloker ektu dekha.mp3");

            /*var content = File.ReadAllText(@"D:/ek poloker ektu dekha.mp3");
            Console.WriteLine(content);*/




            #endregion

            #region Arrays and Lists

            //var list = new Lists();
            //list.Question1();
            //list.Question2();
            //list.Question3();
            //list.Question4();
            //list.Question5();

            #endregion

            #region Working with Text

            /*var strings = new Strings();
            //strings.Question1();
            //strings.Question2();
            //strings.Question3();
            //strings.Question4();
            strings.Question5();*/

            #endregion

            #region Working with Files



            #endregion
        }
        
    }
}