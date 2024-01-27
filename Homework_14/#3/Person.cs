// <copyright file="Person.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMyException;

namespace PPerson
{
	/// <summary>
	/// Класс человека.
	/// </summary>
	internal class Person
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Person"/> class.
		/// </summary>
		/// <param name="name">Имя человека.</param>
		public Person(string name)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(name) == true | name == null)
				{
					throw new EmptyStringException();
				}
				else
				{
					this.name = name;
				}
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex.Message);
				Console.ResetColor();
			}
		}

		private string? name;
	}
}
