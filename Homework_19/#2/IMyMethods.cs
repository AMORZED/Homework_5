// <copyright file="IMyMethods.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

namespace IMMyMethods
{
	/// <summary>
	/// Интерфейс для класса кастомных методов.
	/// </summary>
	internal interface IMyMethods
	{
		/// <summary>
		/// Пишет текст через задачи продолжения с выдачей промежуточных результатов в консоль.
		/// </summary>
		/// <param name="word1">Первое слово/текст.</param>
		/// <param name="word2">Второе слово/текст.</param>
		/// <param name="word3">Третье слово/текст.</param>
		/// <param name="time">Интервал вывода результата в консоль.</param>
		void WriteThreeWordsThrowContinion(string word1, string word2, string word3, int time);

		/// <summary>
		/// Объединяет две строки в одну.
		/// </summary>
		/// <param name="text1">Первый текст.</param>
		/// <param name="text2">Второй текст.</param>
		/// <returns>Объедененная строка.</returns>
		string MergeText(string text1, string text2);
	}
}
