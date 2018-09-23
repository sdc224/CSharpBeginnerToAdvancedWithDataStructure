using System;
using System.Collections.Generic;

namespace CSharpBeginner
{
    public class Strings
    {
        /*
         *1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
         * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
         */
        public void Question1()
        {
            Console.WriteLine("Enter the expression or string: ");
            var input = Console.ReadLine();
            var lists = new List<int>();
            if (input == null) return;
            var inputSeperated = input.Split('-');

            foreach (var s in inputSeperated)
            {
                lists.Add(Convert.ToInt32(s));
            }

            lists.Sort();

            var isConsecutive = true;
            for (var i = 1; i < lists.Count; i++)
            {
                if (lists[i] == lists[i - 1] + 1) continue;
                isConsecutive = false;
                break;
            }

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }

        /*
         * 2- Write a program and ask the user to enter a few numbers separated by a hyphen.
         * If the user simply presses Enter, without supplying an input, exit immediately;
         * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. 
         */
        public void Question2()
        {
            Console.Write("Enter few numbers: ");
            var input = Console.ReadLine();
            var number = new List<int>();
            var hasDuplicate = false;
            var unique = new List<int>();

            if (string.IsNullOrWhiteSpace(input)) return;
            foreach (var s in input.Split('-'))
            {
                number.Add(Convert.ToInt32(s));
            }

            foreach (var num in number)
            {
                if(!unique.Contains(num))
                    unique.Add(num);
                else
                {
                    hasDuplicate = true;
                    break;
                }
            }

            Console.WriteLine(hasDuplicate ? "Duplicate" : "");
        }

        /*
         * 
           3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
           A valid time should be between 00:00 and 23:59. 
           If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
           If the user doesn't provide any values, consider it as invalid time. 
         */
        public void Question3()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
                return;
            }

            var time = input.Split(':');
            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hour = Convert.ToInt32(time[0]);
            var min = Convert.ToInt32(time[1]);

            if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
        }

        /*
         * 4- Write a program and ask the user to enter a few words separated by a space.
         * Use the words to create a variable name with PascalCase.
         * For example, if the user types: "number of students", display "NumberOfStudents".
         * Make sure that the program is not dependent on the input.
         * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". 
         */
        public void Question4()
        {
            Console.Write("Input a string seperated by space: ");
            var input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input))
                return;
            var words = input.Split(' ');

            var pascalCase = "";
            foreach (var word in words)
            {
                pascalCase += char.ToUpper(word[0]) + word.ToLower().Substring(1);
            }

            Console.WriteLine(pascalCase);
        }

        /*
         * 5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
         * So, if the user enters "inadequate", the program should display 6 on the console.
         */
        public void Question5()
        {
            Console.Write("Enter any word: ");
            var input = Console.ReadLine()?.ToLower();


            if (string.IsNullOrWhiteSpace(input))
                return;

            var vowels = new List<char>(new char[] {'a', 'e', 'i', 'o', 'u'});
            var noOfVowels = 0;


            foreach (var inp in input)
            {
                if (vowels.Contains(inp))
                    noOfVowels++;
            }

            Console.WriteLine(noOfVowels);
        }
    }
}