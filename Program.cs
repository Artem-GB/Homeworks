//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) Console.WriteLine($"Большее число -> {num1}, Меньшее число -> {num2}");
if (num1 < num2) Console.WriteLine($"Большее число -> {num2}, Меньшее число -> {num1}");
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
    if (num1>num3) Console.WriteLine($"More number -> {num1}");
if (num2>num1)
    if (num2>num3) Console.WriteLine($"More number -> {num2}");
if (num3>num2)
    if (num3>num1) Console.WriteLine($"More number -> {num3}");
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;
    if (result == 0) Console.WriteLine($"Even number -> {num}");
    if (result != 0) Console.WriteLine($"Odd number -> {num}");
*/


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * 0 + 2;
while (current <= num)
{
        Console.Write(current + " ");
        current = current + 2;
}
