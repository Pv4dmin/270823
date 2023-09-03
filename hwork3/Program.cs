//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ArrayOfNumbers(int[] size)
{ 
    int[] array = new int[size];
    Console.Write("[");
    for (int i = 0; i< size; i++)
    {
        int array[i] = new Random().Next(1);
        Console.Write(array[i]);
    }
    Console.Write("]");

}

int size = InputNum("Длина массива: ");
ArrayOfNumbers(size);
