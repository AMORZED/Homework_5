// <copyright file="Car.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using ICCar;

namespace CCar
{
	/// <summary>
	/// Класс машины.
	/// </summary>
	internal class Car : ICar
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Car"/> class.
		/// </summary>
		/// <param name="id">Номер машины.</param>
		public Car(int id)
		{
			Random rnd = new Random();
			this.id = id;
			this.name = this.listOfBrands[rnd.Next(0, this.listOfBrands.Count)];
			this.age = rnd.Next(0, 10);
		}

		/// <inheritdoc/>
		public int Id
		{
			get
			{
				return this.id;
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

		/// <inheritdoc/>
		public int Age
		{
			get
			{
				return this.age;
			}
		}

		private int id;
		private string name;
		private int age;
		private List<string> listOfBrands = new List<string>()
		{
			"BMW", "Audi", "Nissan", "Toyota", "Hyundai", "Renault", "Acura", "Kia", "Lada", "Mazda", "Honda", "Ford", "Mitsubishi", "Mersedes-Benz", "Shkoda",
		};
	}
}
