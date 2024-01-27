// <copyright file="EmptyStringException.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMyException
{
	/// <summary>
	/// Класс с пользовательским исключением.
	/// </summary>
	internal class EmptyStringException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EmptyStringException"/> class.
		/// </summary>
		/// <param name="message">Выводимое сообщение об ошибке по дефолту.</param>
		public EmptyStringException()
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EmptyStringException"/> class.
		/// </summary>
		/// <param name="text">Кастомное сообщение об ошибке.</param>
		public EmptyStringException(string text)
			: base(text)
		{
		}

		private static string message = "Ошибка! Введена пустая строка!";
	}
}
