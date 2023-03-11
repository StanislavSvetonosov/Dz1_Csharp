// int num = new Random().Next(3,11);

// Console.WriteLine(num);


// выводит случайное число из отрезка(10,100) и показывает наибольшее число

// int num = new Random().Next(10,100);
// Console.WriteLine(num);

// int a = num/10;
// int b = num%10;

// if(a>b)
// {
//   Console.WriteLine("Наибольшая цифра: " +a);
// }
// else
// {
//   Console.WriteLine("наибольшая цифра: " +b);
// }


// Выводит случайное трехзначное число и удаляет второе число
// Напишите программу, которая выводит случайное трехзначное 
// число и удаляет вторую цифру этого числа.


// int num =new Random().Next(100,1000);
// Console.WriteLine(num);

// int a = num/100;
// int d = num%10;
// int result = a*10+d;

// Console.WriteLine(result);


// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому.
//  Если число 2 не кратно числу 1, то программа выводит 
//  остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
// Console.WriteLine("Введите число 1");
// int number1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int number2= Convert.ToInt32(Console.ReadLine());

// // int num =new Random().Next(100,1000);
// // Console.WriteLine(num);

// if(number1%number2==0)
// {
//     Console.WriteLine("Кратны");
// }

// else
// {
//     Console.WriteLine($"Не кратны, остаток от деления равен {number1%number2}");
// }


// int num = Convert.ToInt32(Console.ReadLine());

// if(num%7==0&&num%23==0)
// {
//     Console.WriteLine("Кратны!");
// }
// else
// {
//     Console.WriteLine("Не кратны!");
// }

Console.WriteLine("Enter number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1==num2*num2)
{
    Console.WriteLine(num1 + " является квадратом " + num2);
}
else if  (num2==num1*num1)
{
    Console.WriteLine(num2 + " является квадратом " + num1);
}
else
{
    Console.WriteLine("Не являются квадратом");
}




