// <copyright file="IShop.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using BBuyer;
using CCar;

namespace ISShop
{
	/// <summary>
	/// Интерфейс для магазина.
	/// </summary>
	internal interface IShop
	{
		/// <summary>
		/// Добавление покупателя в магазин.
		/// </summary>
		/// <param name="buyer">Добавляемый покупатель.</param>
		void AddBuyer(Buyer buyer);

		/// <summary>
		/// Добавление машины в магазин.
		/// </summary>
		/// <param name="car">Добавляемая машины.</param>
		void AddCar(Car car);

		/// <summary>
		/// Показать список покупателей.
		/// </summary>
		void ShowListOfBuyers();

		/// <summary>
		/// Показать список машин.
		/// </summary>
		void ShowListOfCars();

		/// <summary>
		/// Показать список сделок.
		/// </summary>
		void ShowListOfDeals();
	}
}
