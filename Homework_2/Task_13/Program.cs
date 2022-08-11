/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 100)
        {
            Console.WriteLine("Ошибка! Третьей цифры нет.");
            return;
        }

        string agrh = number.ToString().Substring(2, 1); // преобразовал число в строку, получил третий символ
        int thirdDigit = Convert.ToInt32(agrh); // преобразовал обратно в число

        Console.WriteLine("Третья цифра (с начала): " + thirdDigit);
    }
}