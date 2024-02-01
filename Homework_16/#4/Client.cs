// <copyright file="Client.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using ICClient;

namespace CClient
{
	/// <summary>
	/// Класс клиента.
	/// </summary>
	internal class Client : IClient
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Client"/> class.
		/// </summary>
		/// <param name="id">Номер клиента.</param>
		public Client(int id)
		{
			Random rnd = new Random();
			this.year = rnd.Next(2020, 2024);
			this.month = rnd.Next(1, 13);
			this.length = rnd.Next(1, 51);
			this.id = id;
		}

		/// <inheritdoc/>
		public int Year
		{
			get
			{
				return this.year;
			}
		}

		/// <inheritdoc/>
		public int Month
		{
			get
			{
				return this.month;
			}
		}

		/// <inheritdoc/>
		public int Length
		{
			get
			{
				return this.length;
			}
		}

		/// <inheritdoc/>
		public int Id
		{
			get
			{
				return this.id;
			}
		}

		private int year;
		private int month;
		private int length;
		private int id;
	}
}
