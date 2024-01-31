// <copyright file="Kindergarten.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CChild;
using IKKindergarten;

namespace KKindergarten
{
	/// <summary>
	/// Класс детского сада.
	/// </summary>
	internal class Kindergarten : IKindergarten
	{
		/// <summary>
		/// Делегат для события.
		/// </summary>
		/// <param name="chld">Ребенок, оканчивающий детский сад.</param>
		public delegate void EventDelegate(Child chld);

		/// <summary>
		/// Событие окончания детского сада.
		/// </summary>
		public event EventDelegate? ChildIsOveredKindergarten;

		/// <inheritdoc/>
		public void ShowList()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("СПИСОК ДЕТЕЙ ДЕТСКОГО САДА:");
			Console.ResetColor();

			for (int i = 0; i < this.listOfChilds.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {this.listOfChilds[i].Name}");
			}
		}

		/// <inheritdoc/>
		public void AddChild(Child chld)
		{
			this.listOfChilds.Add(chld);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Ребенок '{chld.Name}' принят в детский сад!");
			Console.ResetColor();
		}

		/// <inheritdoc/>
		public void OverKindergarten(Child chld)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Ребенок '{chld.Name}' окончил детский сад!");
			Console.ResetColor();
			this.ChildIsOveredKindergarten?.Invoke(chld);
			this.listOfChilds.Remove(chld);
		}

		private List<Child> listOfChilds = new List<Child>();
	}
}
