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
            Console.WriteLine("Ошибка! Введенные данные не верны.");
            return;
        }
        
        while (number > 10)
        {
            number = number / 10;

            if (number < 100)
            {
                while (number > 10)
                {
                    number = number - 10;
                    if (number < 10)
                    {
                        Console.WriteLine("Вторая (с начала) цифра: " + number);
                    }
                }
            }
        }
        
        Console.WriteLine("Готово!");
    }
}