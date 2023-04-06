// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Программа записывает значения по убыванию, а не так, как делали на семинаре.
// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine());

// int count = 1;
// Console.WriteLine(PrintNumber(num, count));
// int PrintNumber(int num, int count)
// {
//   if (count == num)
//     return num;
//   else
//     Console.Write($"{PrintNumber(num, count + 1)}" + " ");
//   return count;
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.WriteLine("Введите первое число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int m = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int n, int m)
// {
//     int sum = n;
//     if (n == m)
//         return 0;
//     else
//     {
//         n++;
//         sum = n + SumNumber(n, m);
//         return sum;
//     }
// }
// Console.Write(SumNumber(n - 1, m));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Console.WriteLine("Введите первое число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int m = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0 && n > 0)
//     {
//         return Akkerman(n - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(n - 1, Akkerman(n, m - 1)));
//     }
// }
// Console.Write(Akkerman(n, m)); 