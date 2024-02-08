// <copyright file="IPizzeria.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace IPPizeria
{
	/// <summary>
	/// Интерфейс для пиццерии.
	/// </summary>
	internal interface IPizzeria
	{
		/// <summary>
		/// Gets максимальное кол-во работнкиов, работающих единовременно.
		/// </summary>
		int MaxWorkers { get; }

		/// <summary>
		/// Создает работника, который начинает готовить.
		/// </summary>
		/// <param name="employeesNumber">Номер работника.</param>
		void StartCook(int employeesNumber);

		/// <summary>
		/// Запускает процесс приготовления.
		/// </summary>
		void Cook();
	}
}
