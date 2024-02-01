// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

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
			int[] mass = new int[] { -10, 22, 13, 43, -5, -12, 100 };

			ExtractEvenNegativeNumbersWithReverse(mass);
		}

		/// <summary>
		/// Извлекает четные отрицательные числа в обратном порядке.
		/// </summary>
		/// <param name="mass">Целочисленный массив.</param>
		internal static void ExtractEvenNegativeNumbersWithReverse(int[] mass)
		{
			var selectedNumbers = mass.Where(i => i < 0 & i % 2 == 0).Reverse();

			foreach (var i in selectedNumbers)
			{
				Console.Write($"{i} ");
			}
		}
	}
}
