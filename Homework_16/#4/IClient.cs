// <copyright file="IClient.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICClient
{
	/// <summary>
	/// Интерфейс для клиента.
	/// </summary>
	internal interface IClient
	{
		/// <summary>
		/// Gets год занятий клиента.
		/// </summary>
		public int Year { get; }

		/// <summary>
		/// Gets месяц занятий клиента.
		/// </summary>
		public int Month { get; }

		/// <summary>
		/// Gets продолжительность занятий клиета.
		/// </summary>
		public int Length { get; }

		/// <summary>
		/// Gets номер клиента.
		/// </summary>
		public int Id { get; }
	}
}
