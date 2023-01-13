// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int num1=0;
while(num1<=0) //ПРОВЕРКА КОРРЕКТНОСТИ ВВОДА
    {
    Console.Write("Введите положительное целое число: ");
    num1 = int.Parse(Console.ReadLine());
    if (num1<=0) Console.WriteLine("Неверное число!");
    }
for (int i=1; i<=num1 ;i++)
    {
    if (i%2==0) Console.Write(i + "  ");

    }