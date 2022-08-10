class Program
{
    static void Main(string[] agrs) 
    {
        int[] numbers = { 1, 3, 4, 546, 67, 4 }; // массив указывается квадратными скобками
        System.Console.WriteLine(numbers[0]); // 1
        int len = numbers.Length;
        Console.WriteLine(numbers[numbers.Length - 1]);
    }
}