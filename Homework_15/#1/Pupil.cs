// <copyright file="Pupil.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using IPPupil;

namespace PPupil
{
	/// <summary>
	/// Класс ученика.
	/// </summary>
	internal class Pupil : IPupil
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Pupil"/> class.
		/// </summary>
		/// <param name="firstName">Имя ученика.</param>
		/// <param name="lastName">Фамилия ученика.</param>
		public Pupil(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}

		/// <inheritdoc/>
		public string FirstName
		{
			get
			{
				return this.firstName;
			}
		}

		/// <inheritdoc/>
		public string LastName
		{
			get
			{
				return this.lastName;
			}
		}

		private string firstName;
		private string lastName;
	}
}
