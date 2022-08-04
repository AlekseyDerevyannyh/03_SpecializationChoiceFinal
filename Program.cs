﻿// **Задача**: Написать программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using System;
using static System.Console;

Clear();

string[] TrimString (string[] array, int trimLength) {
	int resultSize = 0;
	for (int i = 0; i < array.Length; i ++)
		if (array[i].Length <= trimLength)	resultSize ++;
	if (resultSize == 0)					return new string[]{""};

	string[] result = new string[resultSize];
	int resultIndex = 0;
	for (int i = 0; i < array.Length; i ++)
		if (array[i].Length <= trimLength) {
			result[resultIndex] = array[i];
			resultIndex ++;
		}
	return result;
}