// Задача 30: Напишите программу,которая выводит массив из 8 элементов,
// заполненный нулями и елиницами в случайном порядке.

// [1,0,1,1,0,1,0,0]


int[] RandomArray(int arrLenght)
{
    int[] arr = new int[arrLenght];
    for (int i = 0; i < arrLenght; i ++)
    {
        arr[i] = new Random().Next(2);
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