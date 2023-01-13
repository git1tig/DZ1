// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();
if (num1>num2) 
      Console.WriteLine("Число " + num1 +  "> " + num2);
else 
    Console.WriteLine("Число " + num2 + " > " + num1);
