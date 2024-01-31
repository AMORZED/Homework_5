// <copyright file="Director.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDDirector;
using PPupil;

namespace DDirector
{
	/// <summary>
	/// Класс диретора.
	/// </summary>
	internal class Director : IDirector
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Director"/> class.
		/// Создание.
		/// </summary>
		/// <param name="name">Имя директора.</param>
		public Director(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// Gets имя директора.
		/// </summary>
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <inheritdoc/>
		public void NewPupilAddedToSchoolHandler(Pupil ppl)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"Директор  '{this.name}' получил информацию об ученике '{ppl.FirstName} {ppl.LastName}' и отправил сообщение с приветствием его родителям!");
			Console.ResetColor();
		}

		private string name;
	}
}
