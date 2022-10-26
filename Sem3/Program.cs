// ДЗ Семинар 3
// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Polindrom(int n)
{
int temp = n;
int rev = 0;

while(n > 0)
{
   int dig = n % 10;
    rev = rev * 10 + dig;
    n = n / 10;
}
if(temp == rev)
   
    Console.WriteLine($"Это число является полиндромом");
else
   
    Console.WriteLine($"Это число не является полиндромом");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Polindrom(num);
*/

//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Point(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double line1 = x1 - x2;
    double line2 = y1 - y2;
    double line3 = z1 - z2;
    double result = Math.Round(Math.Sqrt(line1*line1 + line2*line2) + (line3*line3), 2);
    return result;
}
Console.WriteLine("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y2: ");
double y2= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Длина отрезка {Point(x1, y1, z1, x2, y2, z2)}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Table(int number)
{
    int index = 1;
    while(index <= number)
    {
        double result = Math.Pow(index,3);
        Console.Write(result + " ");
        index++;
    }
}
Console.WriteLine("Введите число: ");
int res = Convert.ToInt32(Console.ReadLine());
Table(res);

*/