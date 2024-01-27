// <copyright file="Seller.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSeller
{
	/// <summary>
	/// Класс продавца.
	/// </summary>
	internal class Seller
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Seller"/> class.
		/// </summary>
		/// <param name="name">Имя продавца.</param>
		public Seller(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("Необходимо задать продавцу имя!");
			}
			else
			{
				this.name = name;
			}
		}

		/// <summary>
		/// Gets or sets name of seller.
		/// </summary>
		public string Name
		{
			get
			{
				return this.name;
			}

			set
			{
				this.name = value;
			}
		}

		private string name;
	}
}
