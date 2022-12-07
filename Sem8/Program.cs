
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
        {
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    array[i, j] = new Random().Next(minValue, maxValue + 1);

            return array;
        }

        void Show2dArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }
        

        // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void Max(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k ] = temp;
                    }
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

        Max (myArray);
        Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int Searsh(int[,] array)
{
    
        int sum = int.MaxValue;
        int index = 0;
          
        for (int i = 0; i < array.GetLength(0); i++)
            {
              int temp = 0; 
 
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                        temp += array[i,j];
                    }
                    if (temp < sum)
                     {
                     sum = temp;
 
                     index = i;
                     }
            }
           return index;  
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

       Console.Write($" Наименьшая сумма элементов в строке {Searsh(myArray)+1}"); 
       */

       //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
       int[,]Matrix(int[,] matrix1, int[,] matrix2)
       {
        int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
        if(matrix1.GetLength(0) == matrix2.GetLength(1))
        {
            
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
               for (int k = 0; k < matrix2.GetLength(0); k++)
                    newMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
        }
        return result;

       }

        Console.Write("Input a first matrix: ");
       Console.Write("Input a number of rows: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min of columns: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min posible value: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a max posible value: ");
        int max = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input a second matrix: ");
       Console.Write("Input a number of rows: ");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min of columns: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min posible value: ");
        int min2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a max posible value: ");
        int max2 = Convert.ToInt32(Console.ReadLine());

        int[,] firstMatrix = ReturnRandom2DArray(m, n, min, max);
        Show2dArray(firstMatrix, "First matrix:");
        int[,] secondMatrix = ReturnRandom2DArray(numX2, numY2, min2, max2);
        Show2dArray(secondMatrix, "Second matrix:");
        int[,] result = Matrix(firstMatrix, secondMatrix);
        Show2dArray(resultMatrix, "Result matrix:");
*/
/*

int[,] Matrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    if (matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
            resultMatrix[i,j]=0;
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
                }
            }
        }
    }
    return resultMatrix;
}
Console.WriteLine("First matrix data:");
Console.Write("Enter a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second matrix data:");

Console.Write("Enter a number of rows: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = CreateRandom2dArray(m, n, min, max);
Show2dArray(firstMatrix);
int[,] secondMatrix = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(secondMatrix);
int[,] resultMatrix = Matrix(firstMatrix, secondMatrix);
Show2dArray(resultMatrix);

*/

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
/*
int[] GetUniqueArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minValue, maxValue);
        if (i != 0)
        {
            for (int j = 0; j < i; j++)
                while (array[j] == array[i])
                {
                    array[i] = rand.Next(minValue, maxValue + 1);
                    j = 0;
                }
        }
    }
    return array;
}




int[,,] GetUnique3DArray(int x=2, int y=2, int z=2, int minValue=10, int maxValue=99)
{
    int[,,] array = new int[x, y, z];
    int[] baseArray = GetUniqueArray(x * y * z, minValue, maxValue);
    int count = 0;
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = baseArray[count];
                count++;
            }
    return array;
}
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string output = string.Empty;
            for (int k = 0; k < array.GetLength(2); k++)
                output += $"{array[i, j, k]}({i},{j},{k}) ";
            Console.WriteLine(output);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Enter three dimensions of the array (x * y * z <= 90)");
Console.Write("Enter x dimension of the array: ");
int arrX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y dimension of the array: ");
int arrY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z dimension of the array: ");
int arrZ = Convert.ToInt32(Console.ReadLine());
int[,,] rand3DArr = GetUnique3DArray(arrX, arrY, arrZ);
Show3DArray(rand3DArr);
*/


// Напишите программу, которая заполнит спирально массив 4 на 4

void SnailFillArray(int[,] array)
{
    int iStart = 0, iEnd = 0, jStart = 0, jEnd = 0;

    int i = 0;
    int j = 0;

    for (int k = 0; k < array.Length; k++)
    {
        array[i, j] = k + 1;
        if (i == iStart && j < array.GetLength(1) - jEnd - 1)
            j++;
        else if (j == array.GetLength(1) - jEnd - 1 && i < array.GetLength(0) - iEnd - 1)
            i++;
        else if (i == array.GetLength(0) - iEnd - 1 && j > jStart)
            j--;
        else
            i--;

        if ((i == iStart + 1) && (j == jStart) && (jStart != array.GetLength(1) - jEnd - 1)){
            iStart++;
            iEnd++;
            jStart++;
            jEnd++;
        }
    }
}

Console.Write("Enter a number of rows: ");
int snailRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int snailCols = Convert.ToInt32(Console.ReadLine());
int[,] snailArr = new int[snailRows, snailCols];
Show2dArray(snailArr);
SnailFillArray(snailArr);
Show2dArray(snailArr);
