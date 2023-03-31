// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double [,] array = new double [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     array[i,j] = new Random().Next(-99,100);
//     Console.Write(array[i,j]+" ");
//   }
//   Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.WriteLine("Введите позицию строки ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию столбца ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[10, 10];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     array[i, j] = new Random().Next(0, 10);
//     Console.Write(array[i,j]+" ");
//   }
//   Console.WriteLine();
// }
// Console.WriteLine();
// if ((num1 > array.GetLength(0)) || (num2 > array.GetLength(1)))
// {
//   Console.WriteLine(" Такого элемента нет ");
// }
// else
// {
//   Console.WriteLine($" Значение элемента {num1}-строки и {num2}-столбца = {array[num1-1,num2-1]}");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.WriteLine("Введите размерность массива, количество строк = ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размерность массива, количество столбцов = ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     array[i, j] = new Random().Next(0, 10);
//     Console.Write(array[i,j]+" ");
//   }
//   Console.WriteLine();
// }
// Console.WriteLine("-------------------------");
// for (int j = 0; j < array.GetLength(1); j++)
// {
//   double sum = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     sum+=array[i,j];
//   }
//   Console.WriteLine($"Среднее арифметическое {j+1} столбца = {sum/array.GetLength(0)}");
// }