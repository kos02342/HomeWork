//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exp(int num1, int num2)
{
int num = 1;
for (int current = 1; current <= num2; current++)
    num *= num1;
return num;

}

Console.Write( "Введите число A: ");
int A = Convert. ToInt32(Console. ReadLine ());
Console.Write( "Введите натуральное число B: ");
int B = Convert. ToInt32(Console. ReadLine ());
Console.WriteLine ($" {Exp(A, B)}");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int Sum (int number)

{
int count = 0;
while (number > 0)
{
count = count + number % 10;
number /= 10; 
}
return count;
}
Console.Write("Введите число: ");
int a = Convert. ToInt32 (Console. ReadLine ());
Console.WriteLine($"Сумма цифр числа {a} {Sum (a)}");

*/

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"ВВедите элемент массива {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("\nМассив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
PrintArray(myArray);
*/