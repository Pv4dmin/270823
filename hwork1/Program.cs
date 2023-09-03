//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int Deg(int numA, int numB)
{
    int res = (int)Math.Pow(numA, numB);
    return res;
}

int numA = InputNum("Введите число А: ");
int numB = InputNum("Введите число B: ");
int result = Deg(numA, numB);
Console.Write(result);