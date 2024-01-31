// <copyright file="ISchool.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPupil;
using static SSchool.School;

namespace ISSchool
{
	/// <summary>
	/// Интерфейс для школы.
	/// </summary>
	internal interface ISchool
	{
		/// <summary>
		/// Событие добавления нового ученика.
		/// </summary>
		event EventDelegate? NewPupilAddedToSchool;

		/// <summary>
		/// Добавление ученика в школу.
		/// </summary>
		/// <param name="ppl">Добавляемый ученик.</param>
		void AddPupil(Pupil ppl);

		/// <summary>
		/// Поиск ученика.
		/// </summary>
		/// <param name="firstName">Имя ученика.</param>
		/// <param name="lastName">Фамилия ученика.</param>
		/// <returns>Найденный ученик.</returns>
		Pupil? FindPupil(string firstName, string lastName);

		/// <summary>
		/// Отображение списка учеников.
		/// </summary>
		void ShowPupils();
	}
}
