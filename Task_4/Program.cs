// При помощи рекурсии вывести последовательность чисел, 
// с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string message) // Ввод числа
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Recursion(int n)
{
    if (n == 1)
    {
        Console.Write(1);
        return 0;
    }
    else
    {
        int sum = 0;
        int i;
        for (i = 1; sum < n; i++)
        {
            sum += i;
        }
        Console.Write($" {Recursion(--n) + i - 1}");
        return 0;
    }
}

Recursion(Prompt("Введите число: "));