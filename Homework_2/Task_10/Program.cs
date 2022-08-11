/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка! Введено не трёхзначное число.");
            return;
        }
        number = number % 100;
        number = number / 10;
        Console.WriteLine("Вторая цифра: " + number);
    }
}