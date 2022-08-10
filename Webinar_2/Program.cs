/*
int[] numbers = { 1, 3, 4, 546, 67, 4 }; // массив указывается квадратными скобками
System.Console.WriteLine(numbers[0]); // 0 - 1, 1 - 3, 2 - 4 ...
int len = numbers.Length;
Console.WriteLine(numbers[numbers.Length - 1]);
*/

class Program
{
    static void SelectRase()
    {
        string[] namesRase = { "Люди", "Эльфы", "Орки", "гоблины", "Гномы" };
        for (int i = 0; i < namesRase.Length-1; i++)
        {
            Console.Write(i + 1 + " - " + namesRase[i] + ", ");
        }
    }
    static void Main(string[] agrs)
    {
        SelectRase();
    }
}