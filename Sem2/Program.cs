// Домашнее задание 2
// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int number) 
{
    int result = number / 10 % 10;

    return result; 
}

Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Second digit of {number1} is {SecondDigit(number1)}");
*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }

Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Third digit is {ThirdDigit(number1)}");
*/

//  Задача 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


/*
bool Day(int number) 
{
    if (number >= 6)
    return true;
    else
    return false;
}

Console.Write("Ведите номер дня недели: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Этот день выходной? {Day(number1)}");

*/