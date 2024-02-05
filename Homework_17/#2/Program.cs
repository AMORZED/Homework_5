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
			DriveWorker.CreateAndDeleteSomeFolders(@"C:\Users\AMORZED\Desktop\MyFolderWithFolders", "MyTestFolder", 19);
		}
	}
}
