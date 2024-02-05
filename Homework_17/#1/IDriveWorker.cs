// <copyright file="IDriveWorker.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace IDDriveWorker
{
	/// <summary>
	/// Интерфейс с кастомными методами по умолчанию.
	/// </summary>
	public interface IDriveWorker
	{
		/// <summary>
		/// Возвращает кол-во файлов в каталоге.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <returns>Число найденных файлов в каталоге.</returns>
		/// <exception cref="Exception">Ошибка в случае несуществующего каталога.</exception>
		int CountOfFiles(string path);

		/// <summary>
		/// Возвращает данные о файлах в каталоге.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <returns>Массив данных о файлах.</returns>
		FileInfo[] InfoOfFiles(string path);

		/// <summary>
		/// Возвращает кол-во файлов в каталоге с указанным расширением.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <param name="extension">Указанное расширение.</param>
		/// <returns>Число найденных файлов в каталоге.</returns>
		int CountOfSpecificFiles(string path, string extension);

		/// <summary>
		/// Возвращает данные о файлах в каталоге с нужным расширением.
		/// </summary>
		/// <param name="path">Путь к папке.</param>
		/// <param name="extension">Нужное расширение файла.</param>
		/// <returns>Массив данных о найденных файлах.</returns>
		FileInfo[] InfoOfSpecificFiles(string path, string extension);

		/// <summary>
		/// Создает директорию с несколькими папками внутри.
		/// </summary>
		/// <param name="newDirectoryPath">Путь для новой директории.</param>
		/// <param name="nameOfNewDirectory">Название новой директории.</param>
		/// <param name="nameOfnewFolders">Название создаваемых папок внутри директории.</param>
		/// <param name="count">Кол-во создаваемых папок.</param>
		/// <exception cref="Exception">Ошибка в случае существования создвавемой директории.</exception>
		void CreateDirectoryWithFolders(string newDirectoryPath, string nameOfNewDirectory, string nameOfnewFolders, int count);

		/// <summary>
		/// Удаляет директорию.
		/// </summary>
		/// <param name="path">Путь к директории.</param>
		/// <exception cref="Exception">Ошибка в случае несуществования удаляемой директории.</exception>
		void RemoveFolder(string path);
	}
}
