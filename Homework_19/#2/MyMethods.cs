// <copyright file="MyMethods.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;
using System.Threading.Tasks;
using IMMyMethods;

namespace MMyMethods
{
	/// <summary>
	/// Класс с кастомными методами.
	/// </summary>
	internal class MyMethods : IMyMethods
	{
		/// <inheritdoc/>
		public string MergeText(string text1, string text2)
		{
			string result = text1 + " " + text2;
			return result;
		}

		/// <inheritdoc/>
		public void WriteThreeWordsThrowContinion(string word1, string word2, string word3, int time)
		{
			Task<string> task_1 = new Task<string>(() => this.MergeText(string.Empty, word1));
			task_1.Start();

			Thread.Sleep(time);
			Console.WriteLine($"Промежуточный результат - '{task_1.Result}'");

			Task<string> task_2 = task_1.ContinueWith(t => this.MergeText(task_1.Result, word2));

			Thread.Sleep(time);
			Console.WriteLine($"Промежуточный результат - '{task_2.Result}'");

			Task<string> task_3 = task_2.ContinueWith(t => this.MergeText(task_2.Result, word3));

			task_3.Wait();

			Thread.Sleep(time);
			Console.WriteLine($"Промежуточный результат - '{task_3.Result}'");
		}
	}
}
