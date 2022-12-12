// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNums(int n) 
{
if(n>1) ShowNums(n-1);
Console.Write(n + " ");

}
ShowNums(5);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
void ShowNumbers(int m, int n)
{
    if (m > n)
    {
        ShowNumbers(m, n + 1);
        Console.Write($"{n} ");
    }
    else if (n > m)
    {
        Console.Write($"{m} ");
        ShowNumbers(m + 1, n);
    }
    else
        Console.Write($"{m} ");
}
ShowNumbers(5, 10);
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({m},{n}) = {Ackerman(m, n)}");