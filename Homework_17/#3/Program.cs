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
		public static void Main(string[] args)
		{
			string path = @"C:\Users\AMORZED\Desktop\TextFile.txt";
			string text = "Привет с первой строки\n\nПривет с 3й строки";

			StreamWorker.CreateFileWithText(path, text);
			StreamWorker.ReadFileWithText(path);
		}
	}
}
