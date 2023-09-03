//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int NumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {   
        sum += (num % 10);
        num /= 10;
    }
    return sum;
}

int number = InputNum("Введите число: ");
int amount = NumOfDigits(number);
Console.WriteLine(amount);