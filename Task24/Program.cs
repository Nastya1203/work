// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36


int SunNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SunNumbers(number);
Console.WriteLine($"сумму чисел от 1 до {number} = {sumNumbers}");