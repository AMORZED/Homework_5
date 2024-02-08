// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

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
		internal static void Main(string[] args)
		{
			MyMethods myMem = new MyMethods();

			myMem.WriteThreeWordsThrowContinion("Hello", " from ", "callback", 1000);
		}
	}
}
