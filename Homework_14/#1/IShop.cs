// <copyright file="IShop.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSeller;

namespace ISShop
{
	/// <summary>
	/// Интерфейс для магазина.
	/// </summary>
	internal interface IShop
	{
		/// <summary>
		/// Gets or sets seller in the shop.
		/// </summary>
		Seller? Seller { get; set; }

		/// <summary>
		/// Добавление продукта в ассортимент.
		/// </summary>
		/// <param name="product">Добавляемый продукт.</param>
		void AddProduct(object product);

		/// <summary>
		/// Продажа товара.
		/// </summary>
		/// <param name="product">Продаваемый товар.</param>
		/// <param name="moneyOfBuyer">Деньги покупателя.</param>
		void SellProduct(object product, double moneyOfBuyer);

		/// <summary>
		/// Ликвидация магазина.
		/// </summary>
		void LiquidateShop();
	}
}
