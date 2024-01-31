// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using CChild;
using KKindergarten;
using SSchool;

namespace PProgram
{
	/// <summary>
	/// Класс главной программы.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод.
		/// </summary>
		/// <param name="args">Аргументы.</param>
		public static void Main(string[] args)
		{
			Child child_1 = new Child("Natalie");
			Child child_2 = new Child("Stacy");
			Child child_3 = new Child("Sloan");
			Child child_4 = new Child("Clyde");
			Child child_5 = new Child("Pamela");

			Kindergarten kindergarten = new Kindergarten();
			School school = new School();
			kindergarten.ChildIsOveredKindergarten += school.ChildIsOveredKindergartenHandler;

			kindergarten.AddChild(child_1);
			kindergarten.AddChild(child_2);
			kindergarten.AddChild(child_3);
			kindergarten.AddChild(child_4);
			kindergarten.AddChild(child_5);
			kindergarten.ShowList();

			kindergarten.OverKindergarten(child_1);
		}
	}
}
