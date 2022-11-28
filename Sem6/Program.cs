// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int GetNum(int size)

{
int i = 0;
int count = 0;
while(count < size)
{
Console.Write($"Enter {count +1}  number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
i++;
count++;
}
return i;
}

Console.Write("Enter count of numbers: ");
int Num = Convert.ToInt32(Console.ReadLine());

int N = GetNum(Num);
Console.WriteLine($"There's {N} natural numbers");
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2)/(k2 - k1);
    
    if(k1==k2 && b1==b2) 
        Console.WriteLine("Прямые совпадают");
    else if(k1==k2)
        Console.WriteLine("Прямые не пересекаются");
    else
        Console.WriteLine($"Прямые пересекаются в точке: ({x}; {y})");
}


Console.Write("Input  b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input  k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input  k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionLines(b1, k1, b2, k2);
