// <copyright file="DriveWorker.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using IDDriveWorker;

namespace DDriveworker
{
	/// <summary>
	/// Кастомный класс для работы с файлами.
	/// </summary>
	public class DriveWorker : IDriveWorker
	{
		/// <inheritdoc/>
		public int CountOfFiles(string path)
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

		/// <inheritdoc/>
		public FileInfo[] InfoOfFiles(string path)
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

		/// <inheritdoc/>
		public int CountOfSpecificFiles(string path, string extension)
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

		/// <inheritdoc/>
		public FileInfo[] InfoOfSpecificFiles(string path, string extension)
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

		/// <inheritdoc/>
		public void CreateDirectoryWithFolders(string newDirectoryPath, string nameOfNewDirectory, string nameOfnewFolders, int count)
		{
			string directoryPath = newDirectoryPath + $"\\{nameOfNewDirectory}";
			DirectoryInfo drInfo = new DirectoryInfo(directoryPath);

			if (!drInfo.Exists)
			{
				drInfo.Create();
			}
			else
			{
				throw new Exception("Директория, которую вы хотите создать, уже существует!");
			}

			for (int i = 1; i <= count; i++)
			{
				string newFoldersPath = directoryPath + $"\\{nameOfnewFolders}_{i}";
				DirectoryInfo drInfo_1 = new DirectoryInfo(newFoldersPath);

				if (drInfo_1.Exists)
				{
					throw new Exception($"Директория {drInfo_1.FullName} уже существует!");
				}
				else
				{
					drInfo_1.Create();
				}
			}
		}

		/// <inheritdoc/>
		public void RemoveFolder(string path)
		{
			DirectoryInfo dr = new DirectoryInfo(path);

			if (dr.Exists)
			{
				Directory.Delete(path, true);
			}
			else
			{
				throw new Exception("Указанной директории не существует!");
			}
		}
	}
}
