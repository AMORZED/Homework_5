// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using MMyItem;
using Newtonsoft.Json;

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
		/// <param name="args">Параметры.</param>
		internal static void Main(string[] args)
		{
			MyItem myitem = new MyItem("Аркадий", 25);

			string json = JsonConvert.SerializeObject(myitem);
			Console.WriteLine(json);
		}
	}
}
