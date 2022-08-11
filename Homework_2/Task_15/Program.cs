/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


class Program
{
    static void Main(string[] agrs)
    {
        string[] weekDay = { "Понедельнник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        for (int i = 0; i < weekDay.Length-1; i++) // for - это цикл / счетчик / перебор значений от 0 и тд.
        {
            Console.Write(i + 1 + " - " + weekDay[i] + ", ");
        }
        Console.WriteLine(weekDay.Length + " - " + weekDay[weekDay.Length-1] + ".");
        Console.Write("Введите день недели: ");
        int numberDay = Convert.ToInt32(Console.ReadLine());
        if (numberDay == 6 || numberDay == 7)
        {
            Console.WriteLine(weekDay[numberDay-1] + " - выходной день.");
        }
        else
        {
            Console.WriteLine(weekDay[numberDay-1] + " - будний день.");
        }
    }
}