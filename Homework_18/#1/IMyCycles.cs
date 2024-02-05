// <copyright file="IMyCycles.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace IMMyCycles
{
	/// <summary>
	/// Интерфейс для кастомного класса с циклами.
	/// </summary>
	internal interface IMyCycles
	{
		/// <summary>
		/// Цикл с выводом цифр.
		/// </summary>
		void WriteNumbers();

		/// <summary>
		/// Цикл с выводом букв.
		/// </summary>
		void WriteLetters();
	}
}
