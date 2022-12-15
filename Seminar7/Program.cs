using System;

namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter nums");
            // string? str = Console.ReadLine();
            // int num = Convert.ToInt32(str);
            // System.Console.WriteLine(num);
            // if (TryParse(str, out num))
            // {
            //     System.Console.WriteLine(num);
            // }
            // var tmp = new int[10, 10];


            //Задайте двумерный массив размером m×n, 
            //заполненный случайными вещественными числами
            Console.Clear();

            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());

            double[,] arrayDouble = GetArrayDouble(rows, columns, 0, 10);
            PrintArrayDouble(arrayDouble);

            double[,] GetArrayDouble(int m, int n, int min, int max)
            {
                double[,] result = new double[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i, j] = new Random().NextDouble() * (max - min);
                    }
                }
                return result;
            }

            void PrintArrayDouble(double[,] inArray)
            {
                for (int i = 0; i < inArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inArray.GetLength(1); j++)
                    {
                        Console.Write($"{inArray[i, j]:f1} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
            //Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
            //и возвращает информацию о наличии этого элемента в массиве.

            Console.Clear();
            var random = new Random();

            int[,] array = GetArray(random.Next(3, 10), random.Next(3, 10), 0, 10);
            PrintArray(array);
            Console.Write("Введите количество строк массива: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            columns = int.Parse(Console.ReadLine());

            if ((rows >= 0 && rows < array.GetLength(0)) && (columns >= 0 && columns < array.GetLength(1)))
            {
                Console.WriteLine($"Элемент найден {array[rows, columns]}");
            }
            else
            {
                Console.WriteLine("Элемент не найден");
            }



            Console.Write("Введите элемент массива: ");
            int el = int.Parse(Console.ReadLine());



            if (FindElement(array, el, out int column, out int row))
            {
                Console.WriteLine($"Элемент найден column = {column} row ={row}");
            }
            else
            {
                Console.WriteLine("Элемент не найден");
            }




            int[,] GetArray(int m, int n, int min, int max)
            {
                int[,] result = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i, j] = new Random().Next(min, max + 1);
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


            static bool FindElement(int[,] array, int el, out int colum, out int rows)
            {
                colum = 0;
                rows = 0;
                //25
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == el)
                        {
                            colum = j;
                            rows = i;
                            return true;
                        }
                    }
                }
                return false;
            }

            //Задайте двумерный массив из целых чисел. 
            //Найдите среднее арифметическое элементов в каждом столбце.
            Console.ReadLine();

            Console.Clear();

            Console.Write("Введите количество строк массива: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            columns = int.Parse(Console.ReadLine());

            array = GetArray(rows, columns, 0, 10);

            PrintArray(array);

            double[] averageColumns = GetResultArray(array);

            Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");

            char input1 = Console.ReadKey().KeyChar;



            double[] GetResultArray(int[,] array)
            {
                double[] result = new double[array.GetLength(1)];
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        sum += array[j, i];
                    }
                    result[i] = Math.Round(sum / array.GetLength(0), 2);
                    // = Math.Round(sum / array.GetLength(0), 2);
                    // Console.WriteLine($"Среднее арифметическое {result[i]}");
                }
                return result;

            }


            //Задайте двумерный массив. Напишите программу, 
            //которая поменяет местами первую и последнюю строку массива.
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите количество строк массива: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            columns = int.Parse(Console.ReadLine());
            array = GetArray(rows, columns, 0, 10);
            PrintArray(array);
            Console.WriteLine();
            int[] rowAr = GetRowArray(array);
            SortArray(rowAr);
            Console.WriteLine(String.Join(" ", rowAr));
            PrintData(rowAr);





        }

        static int[] GetRowArray(int[,] inArray)
        {
            int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
            int index = 0;
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    result[index] = inArray[i, j];
                    index++;
                }
            }
            return result;
        }

        static void SortArray(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
            {
                for (int j = i + 1; j < inArray.Length; j++)
                {
                    if (inArray[i] > inArray[j])
                    {
                        int k = inArray[i];
                        inArray[i] = inArray[j];
                        inArray[j] = k;
                    }
                }
            }
        }
        static void PrintData(int[] inArray)
        {
            int el = inArray[0];
            int count = 1;
            for (int i = 1; i < inArray.Length; i++)
            {
                if (inArray[i] != el)
                {
                    Console.WriteLine($"{el} встречается {count}");
                    el = inArray[i];
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine($"{el} встречается {count}");
        }


        static bool TryParse(string str, out int num)
        {
            try
            {
                num = int.Parse(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;

            }

        }
    }
}
