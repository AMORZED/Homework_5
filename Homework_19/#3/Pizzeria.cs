// <copyright file="Pizzeria.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;
using IPPizeria;

namespace PPizzeria
{
	/// <summary>
	/// Класс пиццерии.
	/// </summary>
	internal class Pizzeria : IPizzeria
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Pizzeria"/> class.
		/// </summary>
		/// <param name="maxWorkers">Максимальное кол-во работников, работающих единовременно.</param>
		public Pizzeria(int maxWorkers)
		{
			this.MaxWorkers = maxWorkers;
		}

		/// <inheritdoc/>
		public int MaxWorkers
		{
			get
			{
				return this.MaxWorkers;
			}

			private set
			{
				this.sm = new Semaphore(value, value);
			}
		}

		/// <inheritdoc/>
		public void StartCook(int employeesNumber)
		{
			Thread myThread = new Thread(this.Cook);
			myThread.Name = $"#{employeesNumber}";

			Random rnd = new Random();
			Thread.Sleep(rnd.Next(1000, 3000));

			myThread.Start();
		}

		/// <inheritdoc/>
		public void Cook()
		{
			Random rnd = new Random();
			Thread.Sleep(rnd.Next(1000, 3000));

			this.sm.WaitOne();

			Console.WriteLine($"Работник '{Thread.CurrentThread.Name}' пришел на рабочее место.");
			Thread.Sleep(rnd.Next(1000, 3000));

			Console.WriteLine($"Работник '{Thread.CurrentThread.Name}' начал готовить пиццу...");
			Thread.Sleep(rnd.Next(1000, 3000));

			Console.WriteLine($"Работник '{Thread.CurrentThread.Name}' приготовил пиццу!");
			this.sm.Release();
		}

		private Semaphore sm;
	}
}
