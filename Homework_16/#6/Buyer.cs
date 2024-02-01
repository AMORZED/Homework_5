// <copyright file="Buyer.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using IBBuyer;

namespace BBuyer
{
	/// <summary>
	/// Класс покупателя.
	/// </summary>
	internal class Buyer : IBuyer
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Buyer"/> class.
		/// </summary>
		/// <param name="id">Номер покупателя.</param>
		public Buyer(int id)
		{
			Random rnd = new Random();
			this.id = id;
			this.name = this.listOfNames[rnd.Next(0, this.listOfNames.Count)];
			this.carId = rnd.Next(1, 10);
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
		public int CarId
		{
			get
			{
				return this.carId;
			}
		}

		private int id;
		private string name;
		private int carId;
		private List<string> listOfNames = new List<string>()
		{
			"Alex", "Alexander", "Kasey", "Kathryn", "Serge", "Vick", "Waldo", "Zoey", "Fred", "Gabe", "Isabel", "Edie", "Donald", "Clementina", "Brenda", "Ollie", "Maddy", "Natalie", "Preston",
		};
	}
}
