// Задача 33: Задайте массив.
// напишите программу, которая определяет, 
// присутствует ли заднное число в массиве.

// 4; массив[6, 7, 19, 345, 3] -> нет 
// 3; массив[6, 7, 19, 345, 3] -> да 



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

bool FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        {
            return true;
        }
    }
    return false;
}

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int numFind = GetUserInput("Введите число для поиска");
int[] randArr = CreaterArrarRndint(5, -10, 11);
PrintOut(randArr);

bool findNumber = FindNumber(randArr,numFind);

Console.WriteLine(findNumber ? "Искомое число найдено" : "Искомое число не найдено");