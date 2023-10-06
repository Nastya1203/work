// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// парой счиатем первый и послежнйи элемент, 
// второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




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

void PrintOut(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]} ]");
} 


int[] ProductOfPairNumbers(int[] numbers)
{
    int size = numbers.Length/2 + numbers.Length % 2;
    int[] prodOfPairs = new int[size];
    for (int i = 0; i < size; i++)
    {
        prodOfPairs[i] = numbers[i] * numbers[numbers.Length-1-i];
    }
    if(numbers.Length % 2 !=0) prodOfPairs[size-1] = numbers[numbers.Length/2];
    return prodOfPairs;
}

int[] randArr = CreaterArrarRndint(6, 1, 9);
int[] result = ProductOfPairNumbers(randArr);
PrintOut(randArr);
Console.Write(" -> ");
PrintOut(result);
