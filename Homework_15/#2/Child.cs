// <copyright file="Child.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using ICChild;

namespace CChild
{
	/// <summary>
	/// Класс ребенка.
	/// </summary>
	internal class Child : IChild
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Child"/> class.
		/// </summary>
		/// <param name="name">Имя ребенка.</param>
		public Child(string name)
		{
			this.name = name;
		}

		/// <inheritdoc/>
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		private string name;
	}
}
