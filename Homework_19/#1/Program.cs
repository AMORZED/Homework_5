// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;
using System.Threading.Tasks;
using MMyMethods;

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
		/// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
		internal static async Task Main(string[] args)
		{
			MyMethods myMeth = new MyMethods();
			CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
			CancellationToken token = cancelTokenSource.Token;
			token.Register(() =>
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ОПЕРАЦИЯ БЫЛА ПРЕРВАНА ЧЕРЕЗ ТОКЕН!");
				Console.ResetColor();
			});

			myMeth.StartTheMethods(myMeth.Cycle_1, myMeth.Cycle_2, token);
			await Task.Run(() => myMeth.CallCancelRequest(cancelTokenSource, 2000));

			Console.WriteLine("ГЛАВНЫЙ МЕТОД ЗАВЕРШИЛ РАБОТУ!");
		}
	}
}