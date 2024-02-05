// <copyright file="MyItem.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>
using System;
using IMMyItem;
using Newtonsoft.Json;

namespace MMyItem
{
	/// <summary>
	/// Класс кастомного объекта.
	/// </summary>
	[Serializable]
	internal class MyItem : IMyItem
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MyItem"/> class.
		/// </summary>
		/// <param name="name">Имя объекта.</param>
		/// <param name="age">Возраст объекта.</param>
		public MyItem(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		/// <inheritdoc/>
		[JsonProperty(PropertyName = "MyAge")]
		public int Age { get; set; }

		/// <inheritdoc/>
		[JsonIgnore]
		public string Name { get; set; }
	}
}
