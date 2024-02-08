// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using PPizzeria;

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
			Pizzeria pizzeria = new Pizzeria(5);

			for (int i = 1; i <= 10; i++)
			{
				pizzeria.StartCook(i);
			}
		}
	}
}
