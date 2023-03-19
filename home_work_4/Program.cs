// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number2<0)
// {
//   Console.WriteLine("В минусовую степень число не возводят");
// }
// else 
// {
//   Double number = Math.Pow(number1,number2);
// Console.WriteLine(number);
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Введите число");
// int Number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

//  while (Number>0)
//  {
//   sum += Number%10;
//   Number = Number/10;
//  }
//  Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int[] array = new int [8];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]=new Random().Next();
//   Console.WriteLine(array[i]);
// }