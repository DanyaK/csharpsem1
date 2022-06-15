// See https://aka.ms/new-console-template for more information

///=======================
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Task 2!");

Console.Write("a = ");
int input1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
int input2 = Convert.ToInt32(Console.ReadLine());

if (input1 > input2) 
{
    Console.WriteLine("max = " + input1);
} 
else
{
    Console.WriteLine("max = " + input2);
}


///=======================
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

///=======================
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
