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
			DriveWorker driveWorker = new DriveWorker();
			string path = @"C:\Users\AMORZED\Desktop";

			Console.WriteLine($"Количество файлов в указанном каталоге: {driveWorker.CountOfFiles(path)}");

			foreach (var el in driveWorker.InfoOfFiles(path))
			{
				Console.WriteLine($"Название файла: {el.Name}");
				Console.WriteLine($"Размер файла: {Math.Round(el.Length / 1024D / 1024D, 2)} МБ.");
				Console.WriteLine($"Дата создания файла: {el.CreationTime}");
				Console.WriteLine("-----");
			}

			Console.WriteLine($"Количество файлов с указанным расширением в указанном каталоге: {driveWorker.CountOfSpecificFiles(path, "pdf")}");

			foreach (var el in driveWorker.InfoOfSpecificFiles(path, "pdf"))
			{
				Console.WriteLine($"Название файла: {el.Name}");
				Console.WriteLine($"Размер файла: {Math.Round(el.Length / 1024D / 1024D, 2)} МБ.");
				Console.WriteLine($"Дата создания файла: {el.CreationTime}");
				Console.WriteLine("-----");
			}
		}
	}
}
