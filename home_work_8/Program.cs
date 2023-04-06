
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];

// CreateArray(array);
// WriteArray(array);
// Console.WriteLine();
// Console.WriteLine($"Отсортированный массив: ");
// SortArrayLines(array);
// WriteArray(array);

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// void SortArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];

// Console.WriteLine();
// CreateArray(array);
// Console.WriteLine();
// WriteArray(array);

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// int minSumLine = 0;
// int sum = SumLine(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSum = SumLine(array, i);
//   if (sum > tempSum)
//   {
//     sum = tempSum;
//     minSumLine = i;
//   }
// }
// Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sum}) элементов ");


// int SumLine(int[,] array, int i)
// {
//   int sum = array[i, 0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sum += array[i, j];
//   }
//   return sum;
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array1 = new int[rows, columns];
// CreateArray(array1);
// Console.WriteLine();
// WriteArray(array1);

// int[,] array2 = new int[rows, columns];
// CreateArray(array2);
// Console.WriteLine();
// WriteArray(array2);

// int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
// MultiplicationMatrix(array3);
// Console.WriteLine($"\nПроизведение матриц: ");
// WriteArray(array3);

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// int[,] MultiplicationMatrix(int[,] array3)
// {
//   for (int i = 0; i < array1.GetLength(0); i++)
//   {
//     for (int j = 0; j < array2.GetLength(1); j++)
//     {
//       for (int k = 0; k < array2.GetLength(0); k++)
//       {
//         array3[i, j] += array1[i, k] * array2[k, j];
//       }
//     }
//   }
//   return array3;
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите x ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z ");
// int z = Convert.ToInt32(Console.ReadLine());

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $" {array3D[i,j,k]}({i},{j},{k}); ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     array[i] = new Random().Next(10, 100);
//     number = array[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (array[i] == array[j])
//         {
//           array[i] = new Random().Next(10, 100);
//           j = 0;
//           number = array[i];
//         }
//           number = array[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = array[count];
//         count++;
//       }
//     }
//   }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[size, size];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= size * size)
// {
//     array[i, j] = temp;
//     if (i <= j + 1 && i + j < size - 1)
//         j++;
//     else if (i < j && i + j >= size - 1)
//         i++;
//     else if (i >= j && i + j > size - 1)
//         j--;
//     else
//         i--;
//     ++temp;
// }

// WriteArray(array);

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }