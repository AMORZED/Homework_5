// <copyright file="School.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDirector;
using ISSchool;
using PPupil;

namespace SSchool
{
	/// <summary>
	/// Школа.
	/// </summary>
	internal class School : ISchool
	{
		/// <summary>
		/// Делегат для поиска ученика.
		/// </summary>
		/// <param name="ppl">Искомый ученик.</param>
		public delegate void EventDelegate(Pupil ppl);

		/// <inheritdoc/>
		public event EventDelegate? NewPupilAddedToSchool;

		/// <inheritdoc/>
		public void AddPupil(Pupil ppl)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Ученик '{ppl.GetFirstNameOfPupil()} {ppl.GetLastNameOfPupil()}' принят в школу!");
			Console.ResetColor();
			this.listOfPupils.Add(ppl);
			this.NewPupilAddedToSchool?.Invoke(ppl);
			Console.WriteLine();
		}

		/// <inheritdoc/>
		public void ShowPupils()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("СПИСОК УЧЕНИКОВ ШКОЛЫ:");
			Console.ForegroundColor = ConsoleColor.Gray;

			if (this.listOfPupils.Count == 0)
			{
				Console.WriteLine("-- ПУСТО --");
			}

			for (int i = 0; i < this.listOfPupils.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {this.listOfPupils[i].GetFirstNameOfPupil()} {this.listOfPupils[i].GetLastNameOfPupil()}");
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public Pupil? FindPupil(string firstName, string lastName)
		{
			Predicate<Pupil> prPupil = prPupil => prPupil.GetFirstNameOfPupil() == firstName & prPupil.GetLastNameOfPupil() == lastName;
			var result = this.listOfPupils.Find(prPupil);
			if (result == null)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"Ученик '{firstName} {lastName}' не найден! :(");
				Console.ResetColor();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine($"Ученик '{firstName} {lastName}' найден! :D");
				Console.ResetColor();
			}

			return result;
		}

		private List<Pupil> listOfPupils = new List<Pupil>();
	}
}
