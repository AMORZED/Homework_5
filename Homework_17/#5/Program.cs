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
			StreamWorker steamWorker = new StreamWorker();

			string path = @"C:\Users\AMORZED\Desktop\Новый текстовый документ (3).txt";
			string text = "HI, my name is tist file";

			steamWorker.CreateFileWithText(path, text);
			steamWorker.FindAndReplaceASpecificWord(path, "tist", "test");
			steamWorker.ReadFileWithText(path);
		 }
	}
}
