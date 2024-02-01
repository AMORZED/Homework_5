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
			string[] words = new string[] { "Hello", "here", "we", "are" };

			ExtractFirstLetterOfWordsWithReverse(words);
		}

		/// <summary>
		/// Извлекает первую букву каждого слова из массива слов в обратном порядке.
		/// </summary>
		/// <param name="mass">Массив слов.</param>
		internal static void ExtractFirstLetterOfWordsWithReverse(string[] mass)
		{
			var selectedWords = mass.Select(s => s.ElementAt(0)).Reverse();

			foreach (var chr in selectedWords)
			{
				Console.Write($"{chr} ");
			}
		}
	}
}
