// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using SStreamWorker;

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
		/// <param name="args">Параметры.</param>
		 internal static void Main(string[] args)
		 {
			string path = @"C:\Users\AMORZED\Desktop\Новый текстовый документ (3).txt";

			string text = "HI, my name is tist file";

			StreamWorker.CreateFileWithText(path, text);
			StreamWorker.FindAndReplaceASpecificWord(path, "tist", "test");
			StreamWorker.ReadFileWithText(path);
		 }
	}
}
