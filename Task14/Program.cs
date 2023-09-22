// 14. Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да 

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Division(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

int number = GetUserInput("Введите число: ");
bool result = Division(number);

Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");