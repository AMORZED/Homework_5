// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PProgram
{
	/// <summary>
	/// Класс главной программы.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод программы.
		/// </summary>
		/// <param name="args">Параметры.</param>
		internal static void Main(string[] args)
		{
			Mutex mtx = new Mutex();

			ParallelLoopResult result = Parallel.ForEach(new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9 }, SquareOfNumber);

			void SquareOfNumber(int n)
			{
				mtx.WaitOne();

				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write($"Вычисление результата.");
				Thread.Sleep(300);
				Console.Write(".");
				Thread.Sleep(300);
				Console.WriteLine(".");
				Thread.Sleep(300);
				Console.ResetColor();
				Console.WriteLine($"Квадрат числа '{n}' - {n * n}");
				Console.WriteLine();

				mtx.ReleaseMutex();
			}
		}
	}
}
