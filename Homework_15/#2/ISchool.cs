// <copyright file="ISchool.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CChild;

namespace ISSchool
{
	/// <summary>
	/// Интерфейс для школы.
	/// </summary>
	internal interface ISchool
	{
		/// <summary>
		/// Обработчик события окончания ребенком детского сада.
		/// </summary>
		/// <param name="chld">Ребенок, окончивший детский сад.</param>
		void ChildIsOveredKindergartenHandler(Child chld);

		/// <summary>
		/// Отображение списка детей.
		/// </summary>
		void ShowList();

		/// <summary>
		/// Ребенок оканчивает детский сад.
		/// </summary>
		/// <param name="chld">Удаляемый ребенок из детского сада.</param>
		void ChildIsOveredSchool(Child chld);
	}
}
