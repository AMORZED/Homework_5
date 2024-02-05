// <copyright file="IStreamWorker.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISStreamWorker
{
	/// <summary>
	/// Интерфейс для кастомного класса с методами.
	/// </summary>
	internal interface IStreamWorker
	{
		/// <summary>
		/// Создает текстовый файл по указанному пути с указанным текстом.
		/// </summary>
		/// <param name="path">Путь к файлу.</param>
		/// <param name="text">Записываемый текст в файл.</param>
		void CreateFileWithText(string path, string text);

		/// <summary>
		/// Читает текст в текстовом файле и выводит его на консоль.
		/// </summary>
		/// <param name="path">Путь к текстовому файлу.</param>
		void ReadFileWithText(string path);

		/// <summary>
		/// Ищет и заменяет искомое слово в файле на новое.
		/// </summary>
		/// <param name="path">Путь к файлу.</param>
		/// <param name="searchedWord">Искомое слово.</param>
		/// <param name="replacebleWord">Новое слово.</param>
		void FindAndReplaceASpecificWord(string path, string searchedWord, string replacebleWord);
	}
}
