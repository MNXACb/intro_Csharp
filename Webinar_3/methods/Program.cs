// // Вид 1 (ничего не возвращают и ничего не принимают)
// void Method1()
// {
//     Console.WriteLine("Автор: Михаил Быков");
// }
// Method1(); // не забываем указывать скобки при вызове метода, иначе не будет работать




// // Вид 2 (ничего не возвращает но может принимать какие-то аргументы)
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i< count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("текст", 4);
// Method21(count: 4, msg: "новый текст");




// // Вид 3 (чтото возвращает но ничего не прингимает)
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);




// // Вид 4 (что то принимают и чтото возвращают)
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while ( i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// // то же самое но с циклом for

// string Method41(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method41(10, "asdf");
// Console.WriteLine(res);


// // вывод таблицы умножения на экран
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// // ***********Работа с текстом******************
// // Дан текст. В тексте нужно все пробелы заменить четрочками, 
// // маленькие буквы "к" заменить большими "К", 
// // а большие "С" заменить маленькими "с".

// // Ясна ли задача? // следует уточнить условия

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгерое,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty":
// //             012345
// //s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text,' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();



// // Алгоритм сорировки методом выбора / алгоритм метода минимакса / метод максимального
// // 1. Найти позицию минимального элемента в неотсортированной части массива
// // 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// // 3. Повторять пока есть не отсортированные элементы

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int minPosition = 1;

//         for (int j = i + 1; j < array.Length - 1; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temorary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temorary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);



// ********Задание для самостоятельной работы
// Развернуть предыдущий пример. Т.е. сделать сортировку от большего к меньшему.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = 1;

        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temorary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temorary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);