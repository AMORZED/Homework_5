// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System.Collections;
using System.Net.Http.Headers;

namespace PProgram
{
	/// <summary>
	/// Класс с программой.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод.
		/// </summary>
		/// <param name="args">Какие-то параметры.</param>
		internal static void Main(string[] args)
		{
			string[] randomWords = new string[3];
			GetRandomWords(3, randomWords);

			Console.WriteLine("Исходный массив с тремя случайными словами:");
			ShowMass(randomWords);
			Console.WriteLine();

			Console.WriteLine("РЕЗУЛЬТАТ:");
			Console.WriteLine();
			WordsLengthMore5(randomWords);

			void WordsLengthMore5(string[] mass)
			{
				foreach (string word in ReturnWords(mass))
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"\"{word}\" - соответствует условию!");
					Console.ForegroundColor = ConsoleColor.Gray;
				}

				IEnumerable<string> ReturnWords(string[] mass)
				{
					for (int i = 0; i < mass.Length; i++)
					{
						if (mass[i].Length > 5)
						{
							yield return mass[i];
						}

						if (mass[i].Length <= 5)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine($"\"{mass[i]}\" - не соответствует условию!");
							Console.ForegroundColor = ConsoleColor.Gray;
						}
					}
				}
			}

			void ShowMass(string[] mass)
			{
				for (int i = 0; i < mass.Length; i++)
				{
					Console.Write($"| {mass[i]} ");
				}

				Console.WriteLine("|");
			}

			void GetRandomWords(int value, string[] mass)
			{
				Random rnd = new Random();
				List<int> prevValues = new List<int>(); // Список предыдущих значений случайных слов для предотвращения повтора

				Dictionary<int, string> countries = new Dictionary<int, string>()
				{
					[1] = "Argentina",
					[2] = "Chad",
					[3] = "India",
					[4] = "Luxembourg",
					[5] = "Madagascar",
					[6] = "Paraguay",
					[7] = "Seychelles",
					[8] = "Somalia",
					[9] = "Uganda",
					[10] = "Zambia",
				};

				for (int i = 1; i <= value;)
				{
					Retry:
					int randomKey = rnd.Next(1, countries.Count + 1);
					for (int j = 0; j < prevValues.Count; j++)
					{
						if (prevValues[j] == randomKey)
						{
							goto Retry;
						}
					}

					for (int j = 0; j < mass.Length; j++)
					{
						if (mass[j] == null)
						{
							mass[j] = countries[randomKey];
							prevValues.Add(randomKey);
							i++;
							break;
						}
					}
				}
			}
		}
	}
}
