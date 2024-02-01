// <copyright file="IFitnessCenter.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CClient;

namespace IFFitnessCenter
{
	/// <summary>
	/// Интерфейс для фитнес-центра.
	/// </summary>
	internal interface IFitnessCenter
	{
		/// <summary>
		/// Список клиентов фитнес-центра.
		/// </summary>
		void ShowList();

		/// <summary>
		/// Добавление клиента в фитнес-центр.
		/// </summary>
		/// <param name="client">Добавляемый клиент.</param>
		void AddClient(Client client);

		/// <summary>
		/// Лучший год по продолжительности занятий.
		/// </summary>
		void TotalBestYearResult();
	}
}
