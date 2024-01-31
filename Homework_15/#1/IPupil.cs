// <copyright file="IPupil.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace IPPupil
{
	/// <summary>
	/// Интерфейс для ученика.
	/// </summary>
	internal interface IPupil
	{
		/// <summary>
		/// Gets имя ученика.
		/// </summary>
		string FirstName { get; }

		/// <summary>
		/// Gets фамилия ученика.
		/// </summary>
		string LastName { get; }
	}
}
