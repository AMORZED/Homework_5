// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CClient;
using FFitnessCenter;

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
		/// <param name="args">Аргументы.</param>
		internal static void Main(string[] args)
		{
			FitnessCenter fitnessCenter = new FitnessCenter();
			GenerateAndAddClientsForFintessCenter(20, fitnessCenter);

			fitnessCenter.ShowList();

			fitnessCenter.TotalBestYearResult();
		}

		/// <summary>
		/// Генерация и добавление клиентов в фитнес-центр.
		/// </summary>
		/// <param name="countOfClietns">Количество клиентов.</param>
		/// <param name="fc">Объект фитнес-центра.</param>
		internal static void GenerateAndAddClientsForFintessCenter(int countOfClietns, FitnessCenter fc)
		{
			if (fc is FitnessCenter fitnessCenter)
			{
				for (int i = 1; i <= countOfClietns; i++)
				{
					Client client_i = new Client(i);
					fitnessCenter.AddClient(client_i);
				}
			}
		}
	}
}
