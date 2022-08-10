/*
int[] numbers = { 1, 3, 4, 546, 67, 4 }; // массив указывается квадратными скобками
System.Console.WriteLine(numbers[0]); // 0 - 1, 1 - 3, 2 - 4 ...
int len = numbers.Length;
Console.WriteLine(numbers[numbers.Length - 1]);
*/

// for - это цикл / счетчик / перебор значений от 0 и тд.

class Program
{
    static void SelectRase()
    {
        string[] namesRase = { "Люди", "Эльфы", "Орки", "Гоблины", "Гномы" };
        WriteSelect(namesRase);
        Console.WriteLine("Укажите вашу расу? ");
        int numberRase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса: " + namesRase[numberRase-1]);
    }
    static void SelectSex()
    {
        string[] namesSex = { "Женский", "Мужской" };
        WriteSelect(namesSex);
        Console.WriteLine("Укажите ваш пол? ");
        int numberSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш пол: " + namesSex[numberSex-1]);
    }
    static void SelectClass()
    {
        string[] namesClass = { "Воин", "Маг", "Разбойник", "Чернокнижник", "Лучник" };
        WriteSelect(namesClass);
        Console.WriteLine("Укажите ваш класс? ");
        int numberClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш класс: " + namesClass[numberClass-1]);
    }
    static void WriteSelect(string[] args)
    {
        for (int i = 0; i < args.Length-1; i++) // for - это цикл / счетчик / перебор значений от 0 и тд.
        {
            Console.Write(i + 1 + " - " + args[i] + ", ");
        }
        Console.WriteLine(args.Length + " - " + args[args.Length-1] + ".");
        
    }
    static void Main(string[] agrs)
    {
        SelectRase();
        SelectSex();
        SelectClass();
    }
}