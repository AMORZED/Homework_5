// <copyright file="IProduct.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPProduct
{
	/// <summary>
	/// Интерфейс для продуктов.
	/// </summary>
	internal interface IProduct
	{
		/// <summary>
		/// Gets a price of product.
		/// </summary>
		double Price { get; }

		/// <summary>
		/// Gets a type of product.
		/// </summary>
		string TypeOfProduct { get; }
	}
}
