// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Возможно применение если чисел не 3, а любое количество и ввод последовательный.

int maxnum = 0;
int i=0;
for(i=1; i<=3 ; i++)
    {
        Console.Write("Введите " + i + " число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (i == 1) 
            maxnum = num1;           
        else 
            if (num1 > maxnum)  maxnum = num1;
    }
Console.WriteLine("Самое большое число из трёх это: " + maxnum);
