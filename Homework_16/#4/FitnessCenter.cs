// <copyright file="FitnessCenter.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CClient;
using IFFitnessCenter;

namespace FFitnessCenter
{
	/// <summary>
	/// Класс фитнес-центра.
	/// </summary>
	internal class FitnessCenter : IFitnessCenter
	{
		/// <inheritdoc/>
		public void ShowList()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("СПИСОК КЛИЕНТОВ:");
			Console.ResetColor();

			for (int i = 0; i < this.listOfClients.Count; i++)
			{
				Console.WriteLine($"{i + 1}.\tГОД: {this.listOfClients[i].Year}\tМЕСЯЦ: {this.listOfClients[i].Month}\tПРОДОЛЖИТЕЛЬНОСТЬ: {this.listOfClients[i].Length} ч. \tID: {this.listOfClients[i].Id}");
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public void AddClient(Client client)
		{
			this.listOfClients.Add(client);
		}

		/// <inheritdoc/>
		public void TotalBestYearResult()
		{
			var groupByYear = this.listOfClients.OrderBy(x => x.Year).GroupBy(x => x.Year);

			var summaryLengthInYear = from i in groupByYear
									  select new
									  {
										  year = i.Key, length = i.Sum(x => x.Length),
									  };

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("ИТОГИ ПО ГОДАМ:");
			Console.ResetColor();

			foreach (var value in summaryLengthInYear)
			{
				Console.WriteLine($"ГОД: {value.year} \tПРОДОЛЖИТЕЛЬНОСТЬ ВСЕГО: {value.length} ч.");
			}

			Console.WriteLine();

			var biggestYearInLength = summaryLengthInYear.OrderBy(x => x.length).DistinctBy(i => i.length).Last();

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"Год {biggestYearInLength.year} является самым лучшим с продолжительностью занятий {biggestYearInLength.length} ч.!");
			Console.ResetColor();
		}

		private List<Client> listOfClients = new List<Client>();
	}
}
