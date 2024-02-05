// <copyright file="MyStreamWorker.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.IO;

namespace MMyStreamWorker
{
	/// <summary>
	/// Кастомный класс для методов, работающих с потоком.
	/// </summary>
	internal class MyStreamWorker
	{
		/// <summary>
		/// Создает файл с некоторым тектом.
		/// </summary>
		/// <param name="path">Путь к файлу.</param>
		/// <param name="text">Текст для записи в файл.</param>
		public static void CreateFileWithSomeText(string path, string text)
		{
			DirectoryInfo drInfo = new DirectoryInfo(path);

			using (StreamWriter sr = new StreamWriter(path, false))
			{
				sr.Write(text);
				sr.Close();

				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write($"Текст записан в файл ");
				Console.ResetColor();
				Console.WriteLine($"'{drInfo}'");
				Console.ResetColor();
			}
		}

		/// <summary>
		/// Выводит текст из одного файла в другой.
		/// </summary>
		/// <param name="pathFrom">Путь к файлу с копируемым текстом.</param>
		/// <param name="pathIn">Путь к файлу для вставки скопированного текста.</param>
		public static void ReadTextFromFileAndWriteToFile(string pathFrom, string pathIn)
		{
			DirectoryInfo drInfoFrom = new DirectoryInfo(pathFrom);
			DirectoryInfo drInfoIn = new DirectoryInfo(pathIn);

			using (StreamReader sr = new StreamReader(pathFrom))
			{
				string text = sr.ReadToEnd();
				sr.Close();

				using (StreamWriter sw = new StreamWriter(pathIn, true))
				{
					sw.Write(text);
					sw.Close();

					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write($"Текст прочитан и скопирован из файла ");
					Console.ResetColor();
					Console.Write($"'{drInfoFrom.Name}' ");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write($"в файл ");
					Console.ResetColor();
					Console.WriteLine($"'{drInfoIn.Name}'");
				}
			}
		}
	}
}
