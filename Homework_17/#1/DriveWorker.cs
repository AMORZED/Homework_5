// <copyright file="DriveWorker.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System.Runtime.CompilerServices;

namespace DDriveworker
{
	/// <summary>
	/// Кастомный класс для работы с файлами.
	/// </summary>
	public class DriveWorker
	{
		/// <summary>
		/// Возвращает кол-во файлов в каталоге.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <returns>Число найденных файлов в каталоге.</returns>
		/// <exception cref="Exception">Ошибка в случае несуществующего каталога.</exception>
		public static int CountOfFiles(string path)
		{
			if (Directory.Exists(path))
			{
				string[] files = Directory.GetFiles(path);
				int countOfFiles = 0;

				foreach (string file in files)
				{
					countOfFiles++;
				}

				return countOfFiles;
			}
			else
			{
				throw new Exception("Указан несуществующий каталог!");
			}
		}

		/// <summary>
		/// Возвращает данные о файлах в каталоге.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <returns>Массив данных о файлах.</returns>
		public static FileInfo[] InfoOfFiles(string path)
		{
			string[] files = Directory.GetFiles(path);
			List<FileInfo> listOfFileInfo = new List<FileInfo>();

			foreach (string file in files)
			{
				FileInfo fileInfo = new FileInfo(file);
				listOfFileInfo.Add(fileInfo);
			}

			return listOfFileInfo.ToArray();
		}

		/// <summary>
		/// Возвращает кол-во файлов в каталоге с указанным расширением.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <param name="extension">Указанное расширение.</param>
		/// <returns>Число найденных файлов в каталоге.</returns>
		public static int CountOfSpecificFiles(string path, string extension)
		{
			string[] files = Directory.GetFiles(path);
			int countOfFiles = 0;

			foreach (string file in files)
			{
				if (file.Contains(extension))
				{
					countOfFiles++;
				}
			}

			return countOfFiles;
		}

		/// <summary>
		/// Возвращает данные о файлах в каталоге с нужным расширением.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <param name="extension">Нужное расширение файла.</param>
		/// <returns>Массив данных о найденных файлах.</returns>
		public static FileInfo[] InfoOfSpecificFiles(string path, string extension)
		{
			string[] files = Directory.GetFiles(path);
			List<FileInfo> listOfFileInfo = new List<FileInfo>();

			foreach (var el in files)
			{
				if (el.Contains(extension))
				{
					FileInfo fileInfo = new FileInfo(el);
					listOfFileInfo.Add(fileInfo);
				}
			}

			return listOfFileInfo.ToArray();
		}

		/// <summary>
		/// Создает в указанном каталоге несколько папок с нужным названием.
		/// </summary>
		/// <param name="path">Путь к каталогу.</param>
		/// <param name="nameOfFolders">Название создаваемых папок.</param>
		/// <param name="count">Кол-во создаваемых папок.</param>
		public static void CreateAndDeleteSomeFolders(string path, string nameOfFolders, int count)
		{
			for (int i = 0; i <= count; i++)
			{
				string p = path + $"\\{nameOfFolders}_{i}";
				DirectoryInfo drInfo = new DirectoryInfo(p);

				if (!drInfo.Exists)
				{
					drInfo.Create();

					Console.Write($"'{p}'");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(" - ДИРЕКТОРИЯ СОЗДАНА!");
					Console.ResetColor();
				}
				else
				{
					Console.Write($"'{p}'");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(" - ДИРЕКТОРИЯ УЖЕ СУЩЕСТВУЕТ!");
					Console.ResetColor();
				}
			}

			DirectoryInfo drInfo1 = new DirectoryInfo(path);
			Console.WriteLine();
			Console.WriteLine($"Удалить созданные папки в каталоге '{drInfo1.Name}'? (Y/N):");
			string answer = Console.ReadLine() ?? "N";

			if (answer.ToLower() == "y")
			{
				for (int i = 0; i <= count; i++)
				{
					string p = path + $"\\{nameOfFolders}_{i}";
					DirectoryInfo drInfo = new DirectoryInfo(p);

					if (drInfo.Exists)
					{
						drInfo.Delete(true);

						Console.Write($"'{p}'");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine(" - ДИРЕКТОРИЯ УДАЛЕНА!");
						Console.ResetColor();
					}
					else
					{
						Console.Write($"'{p}'");
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(" - ДИРЕКТОРИЯ НЕ СУЩЕСТВУЕТ!");
						Console.ResetColor();
					}
				}

				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("ДИРЕКТОРИИ БЫЛИ УДАЛЕНЫ!");
				Console.ResetColor();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("ДИРЕКТОРИИ НЕ БЫЛИ УДАЛЕНЫ!");
				Console.ResetColor();
			}
		}
	}
}
