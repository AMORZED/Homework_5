// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using EEnumerableExtension;

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
			int[] mass = new int[] { 132, 321, 54, 365, 545, 74, 43, 323 };

			var medianNumber = mass.Median();

			Console.WriteLine(medianNumber);
		}
	}
}
