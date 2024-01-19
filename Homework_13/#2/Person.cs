// <copyright file="Person.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPerson
{
	/// <summary>
	/// Класс персонажа.
	/// </summary>
	internal class Person : IComparable<Person>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Person"/> class.
		/// </summary>
		public Person()
		{
			Random rnd = new Random();
			this.IdNumber = rnd.Next(1, 101);
		}

		/// <summary>
		/// Gets or sets свойство для идентификатора персонажа.
		/// </summary>
		public int IdNumber
		{
			get
			{
				return this.idnumber;
			}

			set
			{
				this.idnumber = value;
			}
		}

		/// <summary>
		/// Метод для получения номера персонажа.
		/// </summary>
		/// <returns>Номер персонажа.</returns>
		public int GetIdNumber()
		{
			return this.idnumber;
		}

		/// <summary>
		/// Переопределение компаратора для персонажей.
		/// </summary>
		/// <param name="other">Другой персонаж для сравнения.</param>
		/// <returns>Место первого персонажа по отношению к другому.</returns>
		public int CompareTo(Person? other)
		{
			if (other is Person)
			{
				if (this.idnumber > other.GetIdNumber())
				{
					return 1;
				}

				if (this.idnumber < other.GetIdNumber())
				{
					return -1;
				}

				return 0;
			}
			else
			{
				throw new ArgumentException("Предоставлен неккоректный тип данных для сравнения!");
			}
		}

		private int idnumber;
	}
}
