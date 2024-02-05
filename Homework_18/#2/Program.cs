// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;

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
			object locker = new object();
			int x;

			for (int i = 1; i <= 3; i++)
			{
				Thread myThread = new Thread(Cycle);
				myThread.Name = $"Поток #{i}";
				myThread.Start();
			}

			void Cycle()
			{
				lock (locker)
				{
					x = 1;

					for (int i = 1; i <= 5; i++)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write($"{Thread.CurrentThread.Name}: ");
						Console.ResetColor();
						Console.WriteLine(x);
						x++;
						Thread.Sleep(175);
					}

					Console.WriteLine();
				}
			}
		}
	}
}
