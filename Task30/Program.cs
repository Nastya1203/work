﻿// Задача 30: Напишите программу,которая выводит массив из 8 элементов,
// заполненный нулями и елиницами в случайном порядке.

// [1,0,1,1,0,1,0,0]


int[] RandomArray(int arrLenght)
{
    int[] arr = new int[arrLenght];
    Random rand = new Random();
    for (int i = 0; i < arrLenght; i++)
    {
        arr[i] = rand.Next(2);
    }
    return arr;
}

// void PrintArray(int[] array)
// {
//     string output = "[";
//     for (int i = 0; i < array.Length; i++)
//     {
//         output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
//     }
//     Console.Write(output);
// }

void PrintArray2(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}

int[] arr = RandomArray(8);
PrintArray2(arr);



// int[] array = new int[8];
// int[] array1 = new int[8] { 5, 6, 9, 8, 9, 9, 0, 6 };
// int[] array2 = new int[] { 5, 6, 9, 8, 9, 9, 0, 6 };
// int[] array3 = { 5, 6, 9, 8, 9, 9, 0, 6 };

// var array4 = new int[8];

// bool[] arrayB = new bool[8];
// double[] arrayD = new double[8];

// Random[] rnd = new Random[8];
