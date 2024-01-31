// <copyright file="IDirector.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPupil;

namespace IDDirector
{
	/// <summary>
	/// Интерфейс для директора.
	/// </summary>
	internal interface IDirector
	{
		/// <summary>
		/// Обработчик события добавления ученика в школу.
		/// </summary>
		/// <param name="ppl">Добавляемый ученик в школу.</param>
		void NewPupilAddedToSchoolHandler(Pupil ppl);

		/// <summary>
		/// Gets имя директора.
		/// </summary>
		public string Name { get; }
	}
}
