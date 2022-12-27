/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/
// double[,] Create2dArray(int rows, int cols)
// {
//     double[,] array = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = Math.Round((new Random().NextDouble() * 100), 2);
//         }
//     }
//     return array;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = Create2dArray(m, n);
// ShowArray(array);

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/
// int[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " " );
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter minimal element: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter maximal element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2dArray(m, n, min ,max);
// ShowArray(array);
// Console.WriteLine("Enter position of elements (x and y) in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > m || y > n) Console.WriteLine("This number doesnt exist");
// else
// {
//     object z = array.GetValue(x,y);
//     Console.WriteLine(z);
// }


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/
// int[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sredArif = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " " );
//             sredArif += array[i, j];
//         }
//         Console.WriteLine();
//         Console.WriteLine($"Cреднее арифметическое элементов каждого столбца {i + 1} = {(double)sredArif/array.GetLength(1)}");
//     }
// }

// Console.WriteLine("Enter number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter min element: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter max element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2dArray(m, n, min, max);
// ShowArray(array);
