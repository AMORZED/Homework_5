// <copyright file="MyMethods.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;
using System.Threading.Tasks;
using IMMyMythods;

namespace MMyMethods
{
	/// <summary>
	/// Класс с кастомными методами.
	/// </summary>
	internal class MyMethods : IMyMythods
	{
		/// <inheritdoc/>
		public void Cycle_1()
		{
			Console.WriteLine($"ЗАПУЩЕН ЦИКЛ...");
			for (int i = 1; i <= 5; i++)
			{
				Thread.Sleep(750);
				Console.WriteLine(i);
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public void Cycle_2()
		{
			Console.WriteLine($"ЗАПУЩЕН ЦИКЛ...");

			char x = 'A';
			for (int i = 0; i <= 4; i++)
			{
				Thread.Sleep(750);
				Console.WriteLine((char)(i + x));
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public async Task StartTheMethods(Action act1, Action act2, CancellationToken token)
		{
			await Task.Run(() => { act1(); }, token);
			await Task.Run(() => { act2(); }, token);
		}
	}
}
