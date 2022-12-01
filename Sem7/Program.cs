
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

    Console.WriteLine();
    }
    Console.WriteLine();  
}

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
        {
            double[,] array = new double[rows, columns];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    array[i,j] = minValue + (new Random().NextDouble()) * (maxValue - minValue);
                     array[i,j] = Math.Round(array[i,j], 2);
                }
            return array;
        }

        void Show2dArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.Write("Input a number of rows: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min of columns: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min posible value: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a max posible value: ");
        int max = Convert.ToInt32(Console.ReadLine());

        double[,] myArray = CreateRandom2dArray(m, n, min, max);
        Show2dArray(myArray);
*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
void Pos(int[,] array, int i, int j)
{
    if (i<array.GetLength(0) && j<array.GetLength(1))
    {
        Console.WriteLine($"The number is {array[i-1,j-1]}");
    }
    else
    Console.WriteLine("Not element");

}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  position rows: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position columns: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Pos(myArray,i,j);
*/


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[] Average(int[,] array)
{
   double[] newarray = new double[array.GetLength(1)];
 
for (int j = 0; j < array.GetLength(0); j++)
                {     

                double sum = 0;
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    sum = sum + array[i,j];
                    double n=sum/array.GetLength(1);
                    newarray[j] = Math.Round(n,2);
                }
                }
return newarray;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }

    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min of columns: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min posible value: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a max posible value: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[,] myArray = CreateRandom2dArray(m, n, min, max);
        Show2dArray(myArray);


double[] my2dArray = Average(myArray);

ShowDoubleArray(my2dArray);