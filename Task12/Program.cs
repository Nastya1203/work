// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetRemainder(int num1, int num2)
{
    return num1 % num2;
}

int firstNum = GetUserInput("Введите первое число");
int secondNum = GetUserInput("Введите второе число");

int rem = GetRemainder(firstNum, secondNum);

if (rem == 0)
{
    Console.WriteLine($"число {firstNum} кратно {secondNum}");
}
else
{
    Console.WriteLine($"число {firstNum}  не кратно {secondNum}, остаток {rem}");
}
