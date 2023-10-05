﻿// Задача 32: Напишите программу замена элементов массива: 
// положительные эл-ты замените на соответ-ие отрицательные, и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]




int[] CreaterArrarRndint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void SignInversion(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = -numbers[i];
    }
}

void PrintOut(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]} ]");
}

int[] randArr = CreaterArrarRndint(5, -10, 11);
PrintOut(randArr);
Console.Write("->");
SignInversion(randArr);
PrintOut(randArr);
Console.Write("");