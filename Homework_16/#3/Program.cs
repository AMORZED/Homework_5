// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PProgram
{
	/// <summary>
	/// Класс главной программы.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод.
		/// </summary>
		/// <param name="args">Аргументы.</param>
		internal static void Main(string[] args)
		{
			int[] mass = new int[] { 11, -20, -5, 4, 5, 8, -1, 9, 2, 0, -11, 15, 3, -3, 4, 0, 20 };

			Console.Write("A) ");
			ExtractPositiveNumbers(mass);

			Console.Write("B) ");
			ExtractOddNumbersWithoutRepetitions(mass);

			Console.Write("C) ");
			ExtractEvenNegativeNumbersWithReverse(mass);

			Console.Write("D) ");
			ExtractPositiveTwoDigitNumbersInAscendingOrder(mass);
		}

		/// <summary>
		/// Извлекает положительные числа.
		/// </summary>
		/// <param name="mass">Целочисленный массив.</param>
		internal static void ExtractPositiveNumbers(int[] mass)
		{
			var selectedNumbersA = mass.Where(x => x > 0).Select(x => x);

			foreach (var i in selectedNumbersA)
			{
				Console.Write($"{i} ");
			}

			Console.WriteLine();
		}

		/// <summary>
		/// Извлекает нечетные числа без повторов.
		/// </summary>
		/// <param name="mass">Целочисленный массив.</param>
		internal static void ExtractOddNumbersWithoutRepetitions(int[] mass)
		{
			var selectedNumbersB = mass.Where(x => x % 2 == 1 | x % 2 == -1).Select(x => x).Distinct();

			foreach (var i in selectedNumbersB)
			{
				Console.Write($"{i} ");
			}

			Console.WriteLine();
		}

		/// <summary>
		/// Извлекает четные отрицательные числа в обратном порядке.
		/// </summary>
		/// <param name="mass">Целочисленный массив.</param>
		internal static void ExtractEvenNegativeNumbersWithReverse(int[] mass)
		{
			var selectedNumbersС = mass.Where(x => x % 2 == 0 & x <= -1).Select(x => x).Reverse();

			foreach (var i in selectedNumbersС)
			{
				Console.Write($"{i} ");
			}

			Console.WriteLine();
		}

		/// <summary>
		/// Извлекает двузначные положительные числа по возростанию.
		/// </summary>
		/// <param name="mass">Целочисленный массив.</param>
		internal static void ExtractPositiveTwoDigitNumbersInAscendingOrder(int[] mass)
		{
			var selectedNumbersD = mass.Where(x => x >= 10 & x <= 99).Select(x => x).OrderBy(x => x);

			foreach (var i in selectedNumbersD)
			{
				Console.Write($"{i} ");
			}

			Console.WriteLine();
		}
	}
}
