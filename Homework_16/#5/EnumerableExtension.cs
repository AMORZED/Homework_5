// <copyright file="EnumerableExtension.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace EEnumerableExtension
{
	/// <summary>
	/// Класс с методом расширения.
	/// </summary>
	internal static class EnumerableExtension
	{
		/// <summary>
		/// Метод расширения для возврата элемента, находящегося в середине (Если элементов массива четное кол-во, возвращается элемент дальше от нуля.)
		/// </summary>
		/// <param name="mass">Массив.</param>
		/// <returns>Элемент из середины массива.</returns>
		/// <exception cref="InvalidOperationException">Ошибка при добавлении пустого массива.</exception>
		public static int Median(this IEnumerable<int> mass)
		{
			if (mass is null || !mass.Any())
			{
				throw new InvalidOperationException("Добавлен пустой массив!");
			}
			else
			{
				var listedArray = mass.ToList();

				int indexOfMedianNumber = (int)Math.Round(listedArray.Count / 2D, MidpointRounding.AwayFromZero);

				if (listedArray.Count % 2 == 0)
				{
					return listedArray[indexOfMedianNumber];
				}
				else
				{
					return listedArray[indexOfMedianNumber - 1];
				}
			}
		}
	}
}
