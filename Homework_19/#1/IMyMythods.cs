// <copyright file="IMyMythods.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;
using System.Threading.Tasks;

namespace IMMyMythods
{
	/// <summary>
	/// Интерфейс для класса кастомных методов.
	/// </summary>
	internal interface IMyMythods
	{
		/// <summary>
		/// Запускает некоторый цикл.
		/// </summary>
		void Cycle_1();

		/// <summary>
		/// Запускает некоторый цикл.
		/// </summary>
		void Cycle_2();

		/// <summary>
		/// Запускает два метода парралельно с возможностью отмены через токен.
		/// </summary>
		/// <param name="act1">Первый метод.</param>
		/// <param name="act2">Второй метод.</param>
		/// <param name="token">Токен для отмены задач.</param>
		/// <returns>Завершение задачи.</returns>
		Task StartTheMethods(Action act1, Action act2, CancellationToken token);
	}
}
