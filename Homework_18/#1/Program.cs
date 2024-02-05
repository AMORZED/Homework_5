// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System.Threading;
using MMyCycles;

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
			MyCycles myCycles = new MyCycles();

			Thread myThread = new Thread(new ThreadStart(myCycles.WriteNumbers));
			myThread.Name = "Вторичный поток: ";
			myThread.Start();

			Thread.CurrentThread.Name = "Главный поток: ";
			myCycles.WriteLetters();
		}
	}
}
