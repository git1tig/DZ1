// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string ChetNechet = "нечётное";
Console.Write("Введите любое целое число:");
int num1 = int.Parse(Console.ReadLine());

if (num1%2==0)
         ChetNechet = "чётное";

Console.WriteLine("Число " + num1 + " - " +ChetNechet + "!");
