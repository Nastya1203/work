﻿// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9,9].
// Найдите сумму отрицательных и полоэительных элементов массива.

// Например, в массиве (3,9,-8,1,0,-7,2,-1,8,-3,-1,6) сумма положительных
// числе равен 29, сумма отрицательных равна -20.


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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }
    return new int[] {sumPositive, sumNegative};
}


int  GetSumPositiveElem(int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int  GetSumNegativeElem(int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}
 
int[] array = CreaterArrarRndint(12, -9, 9);
PrintArray(array);

int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов -> {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов -> {sumPositiveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов -> {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов -> {sumNegativeElem}");