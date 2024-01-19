// <copyright file="MyCollection{T}.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MMyCollection
{
	/// <summary>
	/// Пользовательская коллекция.
	/// </summary>
	/// <typeparam name="T">Обобщенный параметр.</typeparam>
	internal class MyCollection<T> : Collection<T>
		where T : IComparable<T>
	{
		/// <summary>
		/// Переопределение метода добавление объекта в коллекцию.
		/// </summary>
		/// <param name="item">Добавляемый объект.</param>
		public new void Add(T item)
		{
			base.Add(item);
			var count = this.Count;
			var peoplesMass = new T[count];
			this.CopyTo(peoplesMass, 0);

			Array.Sort(peoplesMass);

			for (int i = 0; i < count; i++)
			{
				this[i] = peoplesMass[i];
			}
		}
	}
}
