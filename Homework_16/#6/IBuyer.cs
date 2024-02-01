// <copyright file="IBuyer.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace IBBuyer
{
	/// <summary>
	/// Интерфейс для покупателя.
	/// </summary>
	internal interface IBuyer
	{
		/// <summary>
		/// Gets номер покупателя.
		/// </summary>
		int Id { get; }

		/// <summary>
		/// Gets имя покупателя.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Gets номер машины покупателя.
		/// </summary>
		int CarId { get; }
	}
}
