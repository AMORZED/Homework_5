// <copyright file="StreamWorker.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SStreamWorker
{
	/// <summary>
	/// Кастомный класс для работы с тектовыми файлами.
	/// </summary>
	public class StreamWorker
	{
		/// <summary>
		/// Создает текстовый файл по указанному пути с указанным текстом.
		/// </summary>
		/// <param name="path">Путь к файлу.</param>
		/// <param name="text">Записываемый текст в файл.</param>
		public static void CreateFileWithText(string path, string text)
		{
			using (StreamWriter sw = new StreamWriter(path, false))
			{
				sw.Write(text);
				sw.Close();
			}
		}

		/// <summary>
		/// Читает текст в текстовом файле и выводит его на консоль.
		/// </summary>
		/// <param name="path">Путь к текстовому файлу.</param>
		public static void ReadFileWithText(string path)
		{
			FileInfo fileInfo = new FileInfo(path);
			using (StreamReader sr = new StreamReader(path))
			{
				string text = sr.ReadToEnd();
				sr.Close();

				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine($"ТЕКСТ ИЗ ФАЙЛА '{fileInfo.Name}':");
				Console.ResetColor();
				Console.WriteLine(text);
			}
		}

		/// <summary>
		/// Ищет и заменяет искомое слово в файле на новое.
		/// </summary>
		/// <param name="path">Путь к файлу.</param>
		/// <param name="searchedWord">Искомое слово.</param>
		/// <param name="replacebleWord">Новое слово.</param>
		public static void FindAndReplaceASpecificWord(string path, string searchedWord, string replacebleWord)
		{
			using (StreamReader sr = new StreamReader(path))
			{
				string originalText = sr.ReadToEnd(); // Запись исходного текста в переменную.
				sr.Close();
				string textBefore = originalText.Substring(0, originalText.IndexOf(searchedWord)); // Текст до исправляемого слова.

				string textAfter = originalText.Substring(originalText.IndexOf(searchedWord) + searchedWord.Length); // Текст после исправляемого слова.

				using (FileStream fs = new FileStream(path, FileMode.Open))
				{
					fs.Seek(0, SeekOrigin.Begin);
					byte[] newText = Encoding.Default.GetBytes(textBefore + replacebleWord + textAfter); // Исходный текст с исправленным словом

					fs.Write(newText, 0, newText.Length); // Запись исправленного текста в файл.

					int countOfRemovingLetters = originalText.Length - newText.Count(); // Разница между длиной старого текста и нового (т.е. кол-во лишних символов) Положительное число - есть лишние символы.
					if (countOfRemovingLetters > 0)
					{
						for (int i = countOfRemovingLetters; i > 0; i--) // Замена лишних символов на пробелы
						{
							fs.Seek(-i, SeekOrigin.End);
							byte[] space = Encoding.Default.GetBytes(" ");
							fs.Write(space, 0, space.Length);
						}
					}
				}
			}
		}
	}
}
