// <copyright file="ICar.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICCar
{
	/// <summary>
	/// Интерфейс для машины.
	/// </summary>
	internal interface ICar
	{
		/// <summary>
		/// Gets номер машины.
		/// </summary>
		int Id { get; }

		/// <summary>
		/// Gets марка машины.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Gets возраст машины.
		/// </summary>
		int Age { get; }
	}
}
