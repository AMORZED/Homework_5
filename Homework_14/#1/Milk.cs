// <copyright file="Milk.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPProduct;

namespace MMilk
{
	/// <summary>
	/// Класс продукта "Молоко".
	/// </summary>
	internal class Milk : IProduct
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Milk"/> class.
		/// </summary>
		/// <param name="name">Название молока.</param>
		/// <param name="price">Цена молока.</param>
		public Milk(string name, double price)
		{
			this.name = name;
			this.price = price;
		}

		/// <inheritdoc/>
		public double Price
		{
			get
			{
				return this.price;
			}
		}

		/// <inheritdoc/>
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		/// Gets тип продукта.
		/// </summary>
		public string TypeOfProduct
		{
			get
			{
				return this.typeOfProduct;
			}
		}

		private string typeOfProduct = "Молоко";
		private double price;
		private string name;
	}
}
