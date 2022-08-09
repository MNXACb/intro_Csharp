/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > number1)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine("max =  " + max);