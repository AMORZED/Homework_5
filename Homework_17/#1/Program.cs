// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using DDriveworker;

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
			string path = @"C:\Users\AMORZED\Desktop";

			Console.WriteLine($"Количество файлов в указанном каталоге: {DriveWorker.CountOfFiles(path)}");

			foreach (var el in DriveWorker.InfoOfFiles(path))
			{
				Console.WriteLine($"Название файла: {el.Name}");
				Console.WriteLine($"Размер файла: {Math.Round(el.Length / 1024D / 1024D, 2)} МБ.");
				Console.WriteLine($"Дата создания файла: {el.CreationTime}");
				Console.WriteLine("-----");
			}

			Console.WriteLine($"Количество файлов с указанным расширением в указанном каталоге: {DriveWorker.CountOfSpecificFiles(path, "pdf")}");

			foreach (var el in DriveWorker.InfoOfSpecificFiles(path, "pdf"))
			{
				Console.WriteLine($"Название файла: {el.Name}");
				Console.WriteLine($"Размер файла: {Math.Round(el.Length / 1024D / 1024D, 2)} МБ.");
				Console.WriteLine($"Дата создания файла: {el.CreationTime}");
				Console.WriteLine("-----");
			}
		}
	}
}
