
int [] CreateRandomArry(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1); 

    return  array;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Write ("Input a number of elements: ");
int n = Convert. ToInt32(Console.ReadLine());

int min = 100;
int max = 998;


int[] myArray = CreateRandomArry(n, min, max);
ShowArray(myArray);


int EvenNumber (int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
count++;
}
return count;
}

Console. Write($" Количество четных чисел равно {EvenNumber(myArray)}");

*/
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.Write ("Input a number of elements: ");
int n = Convert. ToInt32(Console.ReadLine());
Console.Write ("Input a min of elements: ");
int min = Convert. ToInt32(Console.ReadLine());
Console.Write ("Input a max of elements: ");
int max = Convert. ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArry(n, min, max);
ShowArray(myArray);

int Number (int[] array)
{
int sum = 0;
for (int i = 1; i < array.Length; i+=2)
{
    sum += array[i];
}
return sum;
}

Console. Write($" Сумма чисел на нечетных позициях равна {Number(myArray)}");
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] DoubleRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minValue + (new Random().NextDouble()) * (maxValue - minValue);
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

double Dif(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) 
        min = array[i];
    
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) 
        max = array[i];
    
    double dif = max - min;
    return dif;
}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write ("Input a number of elements: ");
int n = Convert. ToInt32(Console.ReadLine());
Console.Write ("Input a min of elements: ");
double min = Convert. ToInt32(Console.ReadLine());
Console.Write ("Input a max of elements: ");
double max = Convert. ToInt32(Console.ReadLine());

double[] myArray = DoubleRandomArray(n, min, max);
ShowDoubleArray(myArray);

Console.Write ($"Разность максимального и минимального элементов массива равна {Dif(myArray)}");