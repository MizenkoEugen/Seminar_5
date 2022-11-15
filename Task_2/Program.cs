// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        tempArray[i] = new Random().Next(-99, 100);
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

int Sum(int[] array) // Сумма нечетных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int len = Prompt("Введите длину массива: ");
int[] array = CreateArray(len);
Console.Write($"Сумма нечетных элементов массива: ");
PrintArray(array);
Console.Write($" -> {Sum(array)}");