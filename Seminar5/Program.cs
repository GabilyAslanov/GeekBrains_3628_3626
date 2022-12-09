//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.


int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (var el in array)
{   
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");



//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

int[] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetEvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

 startArray = GetArray(6, 0, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");


int GetSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] startArrayDouble = GetArrayDouble(6, 0, 999);
Console.WriteLine(String.Join(" ", startArrayDouble));
Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    var randon = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = randon.Next(minValue, maxValue + 1) + randon.NextDouble(); //45 + 45.456854368
    }
    return res;
}

double GetDifference(double[] array)
{
    double min = array [0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}