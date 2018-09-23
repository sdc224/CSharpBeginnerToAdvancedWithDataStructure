using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading;

namespace CSharpBeginner
{
	public class Lists
	{
		/*
		 * 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
		 *  If no one likes your post, it doesn't display anything.
		 *  If only one person likes your post, it displays: [Friend's Name] likes your post.
		 *  If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
		 *  If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
		 *
		 * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
		 * Depending on the number of names provided, display a message based on the above pattern.
		 */
		public void Question1()
		{
			var listOfUser = new List<string>();

			while (true)
			{
				Console.WriteLine("Enter names of users who liked your post in facebook (Press Enter to quit): ");
				var likedUsers = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(likedUsers))
					break;
				listOfUser.Add(likedUsers);
			}

			if (listOfUser.Count > 2)
				Console.WriteLine("{0}, {1} and {2} others liked your post", listOfUser[0], listOfUser[1],
					listOfUser.Count - 2);
			else if (listOfUser.Count == 2)
				Console.WriteLine("{0} and {1} liked your post", listOfUser[0], listOfUser[1]);
			else
				Console.WriteLine();
		}


		/*
		 *2- Write a program and ask the user to enter their name.
		 * Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
		 */
		public void Question2()
		{
			Console.WriteLine("Enter your name: ");
			var name = Console.ReadLine();
			if (name == null) return;
			var array = new char[name.Length];

			for (var i = 0; i < name.Length; i++)
				array[i] = name[name.Length - i - 1];

			var reversed = new string(array);
			Console.WriteLine("Reversed name: " + reversed);
		}


		/*
		 * 2- Write a program and ask the user to enter their name. Use an array to reverse the name and
		 * then store the result in a new string. Display the reversed name on the console.
		 */
		public void Question3()
		{
			var numbers = new List<int>();

			while (numbers.Count < 5)
			{
				Console.Write("Enter a number: ");
				var number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

				if (numbers.Contains(number))
				{
					Console.WriteLine("Sorry, but you already entered the number.");
					continue;
				}

				numbers.Add(number);

				numbers.Sort();
			}

			Console.Write("The numbers you have entered in sorted order: ");
			foreach (var number2 in numbers)
			{
				Console.Write(number2 + " ");
			}

			Console.WriteLine();
		}


		/*
		 * 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
		 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
		 */
		public void Question4()
		{
			var numbers = new List<int>();

			Console.WriteLine("Enter numbers or type 'Quit' to exit: ");
			while (true)
			{
				var storedString = Console.ReadLine();

				if(storedString != null && storedString.ToLower() == "quit")
					break;

				numbers.Add(int.Parse(storedString ?? throw new InvalidOperationException()));
			}

			var uniqueNumbers = new List<int>();

			foreach (var number in numbers)
				if (!uniqueNumbers.Contains(number))
					uniqueNumbers.Add(number);

			Console.Write("The unique numbers are: ");
			foreach (var number in uniqueNumbers)
				Console.Write(number + " ");

			Console.WriteLine();
		}


		/*
		 * 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
		 * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
		 * otherwise, display the 3 smallest numbers in the list. 
		 */
		public void Question5()
		{
			string[] elements;

			while (true)
			{
				Console.Write("Enter a list of numbers with comma-seperated: ");

				var input = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(input))
				{
					elements = input.Split(',');
					if (elements.Length >= 5)
						break;
				}

				Console.WriteLine("Invalid List!");
			}

			var numbers = new List<int>();
			foreach (var element in elements)
				numbers.Add(int.Parse(element));

			var smallList = new List<int>();

			while (smallList.Count<3)
			{
				var min = numbers[0];
				foreach (var number in numbers)
				{
					if (number < min)
						min = number;
				}
				smallList.Add(min);
				numbers.Remove(min);
			}

			Console.Write("The three smallest numbers are: ");
			foreach (var i in smallList)
				Console.Write(i + " ");

			Console.WriteLine();
		}
	}
}