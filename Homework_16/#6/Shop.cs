// <copyright file="Shop.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using BBuyer;
using CCar;
using IBBuyer;
using ISShop;

namespace SShop
{
	/// <summary>
	/// Класс магазина.
	/// </summary>
	internal class Shop : IShop
	{
		/// <inheritdoc/>
		public void AddBuyer(Buyer buyer)
		{
			this.listOfBuyers.Add(buyer);
		}

		/// <inheritdoc/>
		public void AddCar(Car car)
		{
			this.listOfCars.Add(car);
		}

		/// <inheritdoc/>
		public void ShowListOfBuyers()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("--- СПИСОК ПОКУПАТЕЛЕЙ ---");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"|ID|\t\t|CAR ID|\t|NAME|");
			Console.ResetColor();

			for (int i = 0; i < this.listOfBuyers.Count; i++)
			{
				Console.WriteLine($"{this.listOfBuyers[i].Id}\t\t{this.listOfBuyers[i].CarId}\t\t{this.listOfBuyers[i].Name}");
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public void ShowListOfCars()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("--- СПИСОК МАШИН ---");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"|CAR ID|\t|AGE|\t\t|NAME|");
			Console.ResetColor();

			for (int i = 0; i < this.listOfCars.Count; i++)
			{
				Console.WriteLine($"{this.listOfCars[i].Id}\t\t{this.listOfCars[i].Age}\t\t{this.listOfCars[i].Name}");
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public void ShowListOfDeals()
		{
			var dealList = from x in this.listOfBuyers
						   join y in this.listOfCars on x.CarId equals y.Id
						   select new { Name = x.Name, Brand = y.Name, Id = y.Id };

			var sortedDealList = dealList.OrderBy(x => x.Name);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("--- СПИСОК ПОКУПОК ---");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("|CAR ID| |BUYER| |BRAND|");
			Console.ResetColor();

			foreach (var i in sortedDealList)
			{
				Console.WriteLine($"{i.Id} - {i.Name} - {i.Brand}");
			}
		}

		private List<Car> listOfCars = new List<Car>();
		private List<Buyer> listOfBuyers = new List<Buyer>();
	}
}
