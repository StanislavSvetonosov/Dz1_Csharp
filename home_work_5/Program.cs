// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] array = new int [4];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]=new Random().Next(100,1000);
//   if (array[i]%2==0)
//   {
//     count++;
//   }
// }
//  Console.WriteLine(String.Join(", ", array));
//  Console.WriteLine($"Количество четных чисел = {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] array = new int [4];
// int SumOddNumber = 0;

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]=new Random().Next(10,100);
//   if (i%2 != 0)
//   {
//     SumOddNumber +=array[i];
//   }
// }
//  Console.WriteLine(String.Join(", ", array));
//  Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {SumOddNumber}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double [5];
// double MaxNumber = 0;
// double MinNumber = 0;

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]=new Random().Next(-99,100);
// }
//   MaxNumber = array[0];
//   MinNumber = array[0];

//   for (int i = 0; i < array.Length; i++)
// {
//   if (array[i]>=MaxNumber)
//   {
//     MaxNumber = array[i];
//   }
//   else if (array[i]<=MinNumber)
//   {
//     MinNumber = array[i];
//   }
// }
//  Console.WriteLine(String.Join(", ", array));
//  Console.WriteLine($"{MaxNumber}, {MinNumber} ");
//  Console.WriteLine($"Разница между максимальным и минимальным элементами массива = { MaxNumber-MinNumber }");
  
  //Другое решение последней задачи
// double[] array = new double [5];
// double MaxNumber = 0;
// double MinNumber = 0;

// for (int i = 0; i < array.Length; i++)
// {
//   Console.WriteLine("Введите {, } элементы массива");
//   array[i] = Convert.ToInt32(Console.ReadLine());
// }
//   MinNumber = array[0];
 
//   for (int i = 0; i < array.Length; i++) 
// {
//   if (array[i]>MaxNumber)
//   {
//     MaxNumber = array[i];
//   }
//   else if (array[i]<MinNumber)
//   {
//     MinNumber = array[i];
//   }
// }
//  Console.WriteLine(String.Join(", ", array));
//  Console.WriteLine($" макс = {MaxNumber}, мин = {MinNumber} ");
//  Console.WriteLine($"Разница между максимальным и минимальным элементами массива = { MaxNumber-MinNumber }");