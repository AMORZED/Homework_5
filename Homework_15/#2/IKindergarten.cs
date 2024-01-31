// <copyright file="IKindergarten.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CChild;
using static KKindergarten.Kindergarten;

namespace IKKindergarten
{
	/// <summary>
	/// Интерфейс для детского сада.
	/// </summary>
	internal interface IKindergarten
	{
		/// <summary>
		/// Событие окончания ребенком детского сада.
		/// </summary>
		event EventDelegate? ChildIsOveredKindergarten;

		/// <summary>
		/// Добавление ребенка в детский сад.
		/// </summary>
		/// <param name="chld">Добавляемый ребенок.</param>
		void AddChild(Child chld);

		/// <summary>
		/// Ребенок заканчивает детский сад.
		/// </summary>
		/// <param name="chld">Ребенок, заканчивающий детский сад.</param>
		void OverKindergarten(Child chld);

		/// <summary>
		/// Отображение списка детей детского сада.
		/// </summary>
		void ShowList();
	}
}
