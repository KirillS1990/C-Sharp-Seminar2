// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int SecondNumber = num / 10 % 10;
// if (num < 100 || num > 999)
// {
//     Console.WriteLine("Введенное число не трехзначное");
// }
// else
// {
//     Console.WriteLine($"Вторая цифра в числе {num} -> {SecondNumber}");
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Console.Clear();
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     int num3 = num  % 10;
//     Console.WriteLine($"Третья цифра в числе -> {num3}");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.Write("Введите цифру, обозначающую день недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 7 || num < 1)
// {
//     Console.WriteLine("Неверный день недели");
// }
// if (num > 5 )
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
