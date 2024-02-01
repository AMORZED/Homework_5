// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using BBuyer;
using CCar;
using SShop;

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
			Shop shop = new Shop();

			GenerateSomeCars(20, shop);
			GenerateSomeBuyers(5, shop);

			shop.ShowListOfCars();
			shop.ShowListOfBuyers();
			shop.ShowListOfDeals();
		}

		/// <summary>
		/// Генерация машин для магазина.
		/// </summary>
		/// <param name="countOfCars">Количество машин.</param>
		/// <param name="shp">Объект магазина.</param>
		internal static void GenerateSomeCars(int countOfCars, Shop shp)
		{
			if (shp is Shop shop)
			{
				for (int i = 1; i <= countOfCars; i++)
				{
					Car car_i = new Car(i);
					shop.AddCar(car_i);
				}
			}
		}

		/// <summary>
		/// Генерация покупателей для магазина.
		/// </summary>
		/// <param name="countOfBuyers">Количество покупателей.</param>
		/// <param name="shp">Объект магазина.</param>
		internal static void GenerateSomeBuyers(int countOfBuyers, Shop shp)
		{
			if (shp is Shop shop)
			{
				for (int i = 1; i <= countOfBuyers; i++)
				{
					Buyer buyer_i = new Buyer(i);
					shop.AddBuyer(buyer_i);
				}
			}
		}
	}
}
