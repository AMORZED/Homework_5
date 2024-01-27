// <copyright file="Shop.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBread;
using ISShop;
using MMilk;
using SSeller;

namespace SShop
{
	/// <summary>
	/// Класс магазина.
	/// </summary>
	internal class Shop : IShop
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Shop"/> class.
		/// </summary>
		/// <param name="seller">Добавление продавца в магазин.</param>
		public Shop(Seller seller)
		{
			this.seller = seller;
		}

		/// <inheritdoc/>
		public Seller? Seller
		{
			get
			{
				if (this.seller == null)
				{
					throw new Exception();
				}
				else
				{
					return this.seller;
				}
			}

			set
			{
				if (this.seller == null)
				{
					this.seller = value;
				}
				else
				{
					throw new Exception("Продавец уже есть в магазине!");
				}
			}
		}

		/// <summary>
		/// Показывает сумму денег в кассе.
		/// </summary>
		public void ShowCashRegister()
		{
			Console.WriteLine($"\nВ кассе находится {this.cashRegister} руб.\n");
		}

		/// <summary>
		/// Добавляет продукт в ассортимент магазина.
		/// </summary>
		/// <param name="product">Добавляемый в ассортимент продукт.</param>
		/// <exception cref="ApplicationException">Попытка добавить существующий товар.</exception>
		public void AddProduct(object product)
		{
			for (int i = 0; i < this.assortment.Count; i++)
			{
				if (this.assortment[i] == product)
				{
					throw new ApplicationException("Товар, который вы пытаетесь добавить в ассортимент уже существует в наличии!");
				}
			}

			if (product is Milk | product is Bread)
			{
				this.assortment.Add(product);
			}
		}

		/// <summary>
		/// Показывает ассортимент магазина.
		/// </summary>
		public void ShowAssortment()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("-- АССОРТИМЕНТ МАГАЗИНА --");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Gray;

			if (this.assortment.Count == 0)
			{
				Console.WriteLine("(   ПУСТО   )");
			}

			for (int i = 0; i < this.assortment.Count; i++)
			{
				if (this.assortment[i] is Bread br)
				{
					Console.WriteLine($"{i + 1}. Хлеб - \'{br.Name}\' | Цена - {br.Price} руб.");
				}

				if (this.assortment[i] is Milk ml)
				{
					Console.WriteLine($"{i + 1}. Молоко - \'{ml.Name}\' | Цена - {ml.Price} руб.");
				}
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public void SellProduct(object product, double moneyOfBuyer)
		{
			if (product is Milk ml)
			{
				if (moneyOfBuyer >= ml.Price)
				{
					if (this.assortment.Contains(ml))
					{
						this.cashRegister += ml.Price;
						this.assortment.Remove(product);

						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine($"Продан товар: Молоко - \'{ml.Name}\' за {ml.Price} руб.");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine($"После продажи в кассе имеется {this.cashRegister} руб.");
						Console.ResetColor();
						Console.WriteLine();
					}
					else
					{
						throw new Exception($"Товара \"Молоко - '{ml.Name}'\" нет в наличии!");
					}
				}
				else
				{
					throw new ApplicationException("У покупателя недостаточно денег для покупки товара! Товар не продан!");
				}
			}

			if (product is Bread br)
			{
				if (moneyOfBuyer >= br.Price)
				{
					if (this.assortment.Contains(br))
					{
						this.cashRegister += br.Price;
						this.assortment.Remove(product);

						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine($"Продан товар: Хлеб - \'{br.Name}\' за {br.Price} руб.");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine($"После продажи в кассе имеется {this.cashRegister} руб.");
						Console.ResetColor();
						Console.WriteLine();
					}
					else
					{
						throw new Exception($"Товара \"Хлеб - \'{br.Name}\'\" нет в наличии!");
					}
				}
				else
				{
					throw new ApplicationException("У покупателя недостаточно денег для покупки товара! Товар не продан!");
				}
			}
		}

		/// <inheritdoc/>
		public void LiquidateShop()
			{
			   if (this.assortment.Count != 0)
			   {
				throw new Exception("Не удалось ликвидировать магазин, т.к. остались непроданные товары!");
			   }

			   if (this.isLiquidated == true)
			   {
				throw new Exception("Не удалось ликвидировать магазин, т.к. он уже ликвидирован!");
			   }
			   else
			   {
				this.seller = null;
				this.cashRegister = 0;
				this.isLiquidated = true;

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("МАГАЗИН ЛИКВИДИРОВАН!");
				Console.ForegroundColor = ConsoleColor.Gray;
			   }
			}

		private List<object> assortment = new List<object>();
		private Seller? seller;
		private double cashRegister;
		private bool isLiquidated = false;
	}
}
