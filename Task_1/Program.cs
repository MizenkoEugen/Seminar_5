// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message) // Ввод числа
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray(int length) // Создание массива
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(100, 1000);
    }
    return tempArray;
}

void PrintArray(int[] intArr) // Вывод массива
{
    Console.Write($"{intArr[0]}");
    for (int i = 1; i < intArr.Length; i++)
    {
        Console.Write($", {intArr[i]}");
    }
}

int Count(int[] array) // Количество четных чисел массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int len = Prompt("Введите длину массива: ");
int[] array = CreateArray(len);
Console.Write($"Количество четных чисел массива: ");
PrintArray(array);
Console.Write($" -> {Count(array)}");