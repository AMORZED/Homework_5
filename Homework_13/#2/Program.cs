// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using MMyCollection;
using PPerson;

namespace PProgram
{
	/// <summary>
	/// Класс с программой.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод программы.
		/// </summary>
		/// <param name="args">Какие-то параметры.</param>
		internal static void Main(string[] args)
		{
			Person person_1 = new Person();
			Person person_2 = new Person();
			Person person_3 = new Person();
			Person person_4 = new Person();
			Person person_5 = new Person();
			Person person_6 = new Person();

			MyCollection<Person> peoples = new MyCollection<Person>()
			{
				person_1, person_2, person_3,
			};

			ShowCollection();
			peoples.Add(person_4);
			ShowCollection();
			peoples.Add(person_5);
			ShowCollection();
			peoples.Add(person_6);
			ShowCollection();

			void ShowCollection()
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("-- СПИСОК --");
				Console.ForegroundColor = ConsoleColor.Gray;
				for (int i = 0; i < peoples.Count; i++)
				{
					Console.WriteLine($"Человек #{i + 1}: ID - {peoples[i].GetIdNumber()}");
				}

				Console.WriteLine();
			}
		}
	}
}
