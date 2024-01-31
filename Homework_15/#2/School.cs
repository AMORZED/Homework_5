// <copyright file="School.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CChild;
using ISSchool;

namespace SSchool
{
	/// <summary>
	/// Класс школы.
	/// </summary>
	internal class School : ISchool
	{
		/// <inheritdoc/>
		public void ShowList()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("СПИСОК ДЕТЕЙ ШКОЛЫ:");
			Console.ResetColor();

			for (int i = 0; i < this.listOfChilds.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {this.listOfChilds[i].Name}");
			}
		}

		/// <inheritdoc/>
		public void ChildIsOveredKindergartenHandler(Child chld)
		{
			this.listOfChilds.Add(chld);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Ребенок '{chld.Name}' принят в школу!");
			Console.ResetColor();
		}

		/// <inheritdoc/>
		public void ChildIsOveredSchool(Child chld)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Ребенок '{chld.Name}' окончил школу!");
			Console.ResetColor();
			this.listOfChilds.Remove(chld);
		}

		private List<Child> listOfChilds = new List<Child>();
	}
}
