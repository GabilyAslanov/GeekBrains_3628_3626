// //Напишите программу, которая перевернёт одномерный массив 
// //(последний элемент будет на первом месте, а первый - на последнем и т.д.)


// int[] array1 = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array1));

// ReversArray1(array1);
// Console.WriteLine(String.Join(" ", array1));

// array1=ReversArray2(array1);
// Console.WriteLine(String.Join(" ", array1));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReversArray1(int[] inArray)       //9 8 34 5 67 2 1
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int tmp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = tmp;
//     }
// }

// int[] ReversArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];

//     }
//     return result;
// }


//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
// Console.Clear();

Console.Write("Введите количество строк массива: ");
var rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArrayMatrix(rows, columns, 10, 99);
PrintArray(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue = 0, int maxValue = 100)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2-> 2

// 1, -7, 567, 89, 223-> 3


// Задача №41

Console.Write("Enter the elements separated by a space: ");
string str = Console.ReadLine(); // "4 78 68  79 34 55 1 -55 -100 -5"

var arrStr = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);// "4" "78" "68" "79" "34" "55" "1" "-55" "-100" "-5"

int[] arr = Array.ConvertAll(arrStr, Convert.ToInt32);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"The number of elements is greater than zero: {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
// Задача №43

Console.WriteLine("Enter a value B1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a value K1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a value B2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a value K2");
double k2 = Convert.ToDouble(Console.ReadLine());

//  Console.Write("Введите через пробел b1, k1, b2 , k2: ");
// string[] f =  Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
//  b1 = double.Parse(f[0]);
//  k1 = double.Parse(f[1]);
//  b2 = double.Parse(f[2]);
//  k2 = double.Parse(f[3]);

//  Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));


double x = (b1 - b2) / (k2 - k1);
double y = k2 * x + b2;
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5
Console.WriteLine($"The point of intersection of two straight lines X: {x}; Y: {y}");
Console.ReadLine();


double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB2 - inB1) / (inK1 - inK2);
    result[1] = inK1 * result[0] + inB1;
    return result;
}