// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using BBread;
using MMilk;
using SSeller;
using SShop;

namespace Hw_1
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
			Seller seller = new Seller("Винни-пух");
			Shop shop = new Shop(seller);

			Bread bread_1 = new Bread("Ржаной", 1.5D);
			Milk milk_1 = new Milk("Вкусное", 2.0D);
			Milk milk_2 = new Milk("Простоквашино", 1.75D);
			Bread bread_2 = new Bread("Пшеничный", 1.8D);

			shop.AddProduct(bread_1);
			shop.AddProduct(milk_1);
			shop.AddProduct(milk_2);
			shop.AddProduct(bread_2);

			shop.ShowAssortment();

			shop.SellProduct(bread_1, 2D);

			shop.ShowAssortment();

			shop.SellProduct(milk_2, 3D);

			shop.ShowAssortment();

			shop.LiquidateShop();
		}
	}
}
