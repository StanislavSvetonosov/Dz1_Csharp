// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.WriteLine("Введите трехзначное число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// int a = number1/100;
// int d = number1%10;
// int result = (number1-(a*100+d))/10;
// Console.WriteLine(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.WriteLine("Введите любое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int a = number1/100;

// if(a>0 && a<10)
//   {
//   Console.WriteLine(a);
//   }
// else if(a>10) 
// {
//   Console.WriteLine(a%10);
// }
// else
// {
//   Console.WriteLine("третьей цифры нет");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Console.WriteLine("Введите день недели");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if(number1<6)
// {
//   Console.WriteLine("рабочий день");
// }
// else if (number1==6 || number1==7)
// {
//   Console.WriteLine("выходной день");
// }

// else
// {
//   Console.WriteLine("Такого дня недели нет");
// }