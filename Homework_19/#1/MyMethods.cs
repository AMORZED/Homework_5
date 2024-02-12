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
			Console.WriteLine($"ЗАПУЩЕН ЦИКЛ (#1)...");
			for (int i = 1; i <= 5; i++)
			{
				Thread.Sleep(750);
				Console.WriteLine(i);
			}
		}

		/// <inheritdoc/>
		public void Cycle_2()
		{
			Console.WriteLine($"ЗАПУЩЕН ЦИКЛ (#2)...");

			char x = 'A';
			for (int i = 0; i <= 4; i++)
			{
				Thread.Sleep(750);
				Console.WriteLine(new string(' ', 2) + (char)(i + x));
			}
		}

		/// <inheritdoc/>
		public async Task StartTheMethods(Action act1, Action act2, CancellationToken token)
		{
			Task.Run(() => { act1(); }, token);
			Task.Run(() => { act2(); }, token);
		}

		/// <inheritdoc/>
		public void CallCancelRequest(CancellationTokenSource kts, int time)
		{
			Thread.Sleep(time);
			kts.Cancel();
		}
	}
}
