// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Prompt(string message) // Ввод числа
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[] CreateArray(int length) // Создание массива
{
    double[] tempArray = new double[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().NextDouble();
    }
    return tempArray;
}

void PrintArray(double[] Array) // Вывод массива
{
    Console.Write($"{Array[0]:F2}");
    for (int i = 1; i < Array.Length; i++)
    {
        Console.Write($", {Array[i]:F2}");
    }
}

double MaxArray(double[] Array) // Максимальное число массива
{
    double tempMax = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (tempMax < Array[i])
        {
            tempMax = Array[i];
        }
    }
    return tempMax;
}

double MinArray(double[] Array) // Минимальное число массива
{
    double tempMin = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (tempMin > Array[i])
        {
            tempMin = Array[i];
        }
    }
    return tempMin;
}

int len = Prompt("Введите длину массива: ");
double[] Array = CreateArray(len);
Console.Write($"Разница между максимальным и минимальным числом массива: ");
PrintArray(Array);
Console.Write($" -> {(MaxArray(Array) - MinArray(Array)):F2}");