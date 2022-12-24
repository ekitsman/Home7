// Д.з. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// double[,] CreatArray()
// {
//     Console.Write("Input a number of rows (m): ");
//     int rows=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns(n): ");
//     int colums=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     double minValue=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     double maxValue=Convert.ToInt32(Console.ReadLine());

//     double[,] array=new double[rows, colums];
//     Random rand = new Random();

//     for(int i=0; i<rows; i++)
//         for(int j =0; j<colums; j++)
//             array [i,j] =Math.Round(rand.Next(-100, 100) + rand.NextDouble(),2);

//     return array;
// }

// void Show2dArray (double[,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array [i,j] + " ");

//         Console.WriteLine( );
//     }
//     Console.WriteLine( );
// }

// double[,] myArray = CreatArray();
// Show2dArray(myArray);

// Д.з.2 Индекс есть такой? Запрашивать индекс
// Если подходит-к элементу.
// Войд?
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет


// int[,] CreatRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int colums=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue=Convert.ToInt32(Console.ReadLine());

//     int[,] array=new int[rows, colums];

//     for(int i=0; i<rows; i++)
//         for(int j =0; j<colums; j++)
//             array [i,j] = new Random().Next(minValue, maxValue+1);

//     return array;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array [i,j] + " ");

//         Console.WriteLine( );
//     }
//     Console.WriteLine( );
// }

// int[,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);

//  Console.Write("Input a row of element: ");
//  int elrows=Convert.ToInt32(Console.ReadLine())-1;
//  Console.Write("Input a column of element: ");
//  int elcolums=Convert.ToInt32(Console.ReadLine())-1;

// void FindElements(int [,] array)
// {
//     if (elrows < 0 | elrows > array.GetLength(0) - 1 | elcolums < 0 | elcolums > array.GetLength(1) - 1)
//         Console.WriteLine("The element does not exist");
//     else
//         Console.WriteLine("Value of the array element = {0}", array[elrows, elcolums]);
// }

// FindElements(myArray);

// Д.з.3
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// По столбцам
// Double массив

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreatRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int colums=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue=Convert.ToInt32(Console.ReadLine());

//     int[,] array=new int[rows, colums];

//     for(int i=0; i<rows; i++)
//         for(int j =0; j<colums; j++)
//             array [i,j] = new Random().Next(minValue, maxValue+1);

//     return array;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array [i,j] + " ");

//         Console.WriteLine( );
//     }
//     Console.WriteLine( );
// }

// int[,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);


// void Arithmetics(int [,] array)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
// }
// }
// Console.WriteLine("The arithmetic mean of the elements in each column:");
// Arithmetics(myArray);