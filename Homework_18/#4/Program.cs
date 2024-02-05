// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;
using System.Threading.Tasks;
using MMyStreamWorker;

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
			Mutex mtx = new Mutex();

			MyStreamWorker.CreateFileWithSomeText(@"C:\Users\AMORZED\Desktop\Новый текстовый документ.txt", "Hello ");
			MyStreamWorker.CreateFileWithSomeText(@"C:\Users\AMORZED\Desktop\Новый текстовый документ (2).txt", "World!");

			Parallel.Invoke(MyTask_1, MyTask_2);

			void MyTask_1()
			{
				Console.WriteLine($"Выполняется поток #{Task.CurrentId}...");
				mtx.WaitOne();
				Thread.Sleep(1000);
				MyStreamWorker.ReadTextFromFileAndWriteToFile(@"C:\Users\AMORZED\Desktop\Новый текстовый документ.txt", @"C:\Users\AMORZED\Desktop\Новый текстовый документ (3).txt");
				mtx.ReleaseMutex();
			}

			void MyTask_2()
			{
				Console.WriteLine($"Выполняется поток #{Task.CurrentId}...");
				mtx.WaitOne();
				Thread.Sleep(1000);
				MyStreamWorker.ReadTextFromFileAndWriteToFile(@"C:\Users\AMORZED\Desktop\Новый текстовый документ (2).txt", @"C:\Users\AMORZED\Desktop\Новый текстовый документ (3).txt");
				mtx.ReleaseMutex();
			}
		}
	}
}
