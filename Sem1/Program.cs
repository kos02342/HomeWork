// ДЗ 1
/*
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if(FirstNumber > SecondNumber)
Console.WriteLine($"Max= {FirstNumber}, Min= {SecondNumber}");
else
Console.WriteLine($"Max= {SecondNumber}, Min= {FirstNumber}");
*/


/*
// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int Max = FirstNumber;

if(Max < SecondNumber)
{
    Max = SecondNumber;
}
if(ThirdNumber > Max)
{
    Max = ThirdNumber;
}
Console.Write($"Max= {Max}");
*/

/*
//Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
Console.Write($"Число {num} является четным");
else
Console.Write($"Число {num} является нечетным");
*/


/*
//Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;
while(current<=num)
{
    Console.Write(current + " ");
    current+=2;
}
*/


