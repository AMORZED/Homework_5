// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System.Security.Cryptography.X509Certificates;
using DDirector;
using PPupil;
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
		internal static void Main(string[] args)
		{
			Pupil pupil_1 = new Pupil("Cooper", "Jones");
			Pupil pupil_2 = new Pupil("Bryce", "Collins");
			Pupil pupil_3 = new Pupil("Toby", "Scott");
			Pupil pupil_4 = new Pupil("Leo", "Parker");
			Pupil pupil_5 = new Pupil("Pamela", "Baker");

			Director director = new Director("Spider-man");
			School school = new School();
			school.NewPupilAddedToSchool += director.NewPupilAddedToSchoolHandler;

			school.AddPupil(pupil_1);
			school.AddPupil(pupil_2);
			school.AddPupil(pupil_3);
			school.AddPupil(pupil_4);
			school.AddPupil(pupil_5);

			school.ShowPupils();

			school.FindPupil("Cooper", "Jones");
		}
	}
}
