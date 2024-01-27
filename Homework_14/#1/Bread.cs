// <copyright file="Bread.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using IPProduct;

namespace BBread
{
	/// <summary>
	/// Класс хлеба.
	/// </summary>
	internal class Bread : IProduct
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Bread"/> class.
		/// Конструктор.
		/// </summary>
		/// <param name="name">Название хлеба.</param>
		/// <param name="price">Цена хлеба.</param>
		public Bread(string name, double price)
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

		private double price;
		private string name;
	}
}
