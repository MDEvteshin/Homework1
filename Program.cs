﻿// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3
// System.Console.WriteLine("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     System.Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
// } 
// else
// {
//     System.Console.WriteLine($"Второе число {num2} больше первого числа {num1}");

// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22
// System.Console.WriteLine("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число ->");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 && num1 > num3) 
// {
//     System.Console.WriteLine($"Первое число {num1} больше второго числа {num2} и больше третьего числа {num3}");
// }    
// else if (num2 > num1 && num2 > num3)
// {
//     System.Console.WriteLine($"Второе число {num2} больше первого числа {num1} и больше третьего числа {num3}");
// }
// else 
// {
//     System.Console.WriteLine($"Третье число {num3} больше первго числа {num1} и больше второго числа {num2}");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// System.Console.WriteLine("Напишите число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 % 2 == 0)
// {
//     System.Console.WriteLine($"Число {num1} является четным");
// }
// else
// {
//     System.Console.WriteLine($"Число {num1} является нечетным");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// System.Console.WriteLine("Введите любое число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if (num > 1)
// {
//     while (evenNumber <= num )
//     {
//         System.Console.Write(evenNumber + " ");
//         evenNumber = evenNumber + 2;
//     }
// }
