// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace PProgram
{
	/// <summary>
	/// Главная программа.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод программы.
		/// </summary>
		/// <param name="args">Какие-то параметры.</param>
		public static void Main(string[] args)
		{
		Begin:
			try
			{
				Console.WriteLine("Введите первое значение в диапазоне 0 - 255:");
				int a = int.Parse(Console.ReadLine() ?? "0");

				try
				{
					if (a < 0 || a > 255)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						throw new ApplicationException();
					}
				}
				catch (ApplicationException)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Вы ввели значение, выходящее за пределы указанного диапазона! (0 - 255)");
					Console.ResetColor();
				}

				Console.WriteLine("Введите второе значение в диапазоне 0 - 255:");
				int b = int.Parse(Console.ReadLine() ?? "0");

				try
				{
					if (b < 0 || b > 255)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						throw new ApplicationException();
					}
				}
				catch (ApplicationException)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Вы ввели значение, выходящее за пределы указанного диапазона! (0 - 255)");
					Console.ResetColor();
				}

				Console.WriteLine($"Результатом выражения ( {a} : {b} )  является значение \'{a / b}\'");
			}
			catch (FormatException)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("НЕВЕРНЫЙ ФОРМАТ! Необходимо ввести целое число!");
				Console.ResetColor();
				Console.WriteLine();
				goto Begin;
			}
			catch (DivideByZeroException)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("НЕВЕРНОЕ ЗНАЧЕНИЕ! На ноль делить нельзя!");
				Console.ResetColor();
				Console.WriteLine();
				goto Begin;
			}
		}
	}
}
