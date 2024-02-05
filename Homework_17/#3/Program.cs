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
			StreamWorker streamWorker = new StreamWorker();

			string path = @"C:\Users\AMORZED\Desktop\TextFile.txt";
			string text = "Привет с первой строки\n\nПривет с 3й строки";

			streamWorker.CreateFileWithText(path, text);
			streamWorker.ReadFileWithText(path);
		}
	}
}
