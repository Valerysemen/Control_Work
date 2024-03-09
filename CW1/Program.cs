//Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк в массиве:");
        int n = int.Parse(Console.ReadLine()!);

        string[] inputArray = new string[n];

        Console.WriteLine("Введите строки для массива:");
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = Console.ReadLine()!;
        }

        string[] newArray = FilterArrayByLength(inputArray);

        Console.WriteLine("Отфильтрованный массив строк длиной меньше или равной 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
    static string[] FilterArrayByLength(string[] inputArray)
    {
        int count = 0;



        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }


        string[] newArray = new string[count];

        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newArray[index] = inputArray[i];
                index++;
            }
        }

        return newArray;
    }
}


