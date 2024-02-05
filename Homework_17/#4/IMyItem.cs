// <copyright file="IMyItem.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace IMMyItem
{
	/// <summary>
	/// Интерфейс для объекта.
	/// </summary>
	internal interface IMyItem
	{
		/// <summary>
		/// Gets or sets имя объекта.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Gets or sets возраст объекта.
		/// </summary>
		int Age { get; set; }
	}
}
