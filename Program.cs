/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[row,col];


FillArray(array);
Console.WriteLine("Начальный массив");
PrintArray(array);
SortRowArray(array);
Console.WriteLine("Отсортированный по убыванию массив");
PrintArray(array);


void FillArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
for (int j=0;j<array.GetLength(1);j++)
array[i,j] = new Random().Next(-10,11);
}


void PrintArray(int[,] array)
{;
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}Console.WriteLine();}



void SortRowArray(int[,] array)
{
for (int i = 0; i < col; i++)
{
for (int j = 0; j < row; j++)
{
for (int k = 0; k < col; k++)
{
if (array[i, j] > array[i, k])
{
int tmp = array[i,j];
array[i,j] = array[i,k];
array[i,k] = tmp;
}
                    }
                }
            }
}
*/



/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


/*
Console.WriteLine("Введите количество строк и столбцов");
int row = Convert.ToInt32(Console.ReadLine());
int col = row;
int [,] array = new int[row,col];
int [] sum = new int[row];


FillArray(array);
Console.WriteLine("Заданный массив");
PrintArray(array);
SumRowArray(array);
MinSumRowArray(sum);




void FillArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
for (int j=0;j<array.GetLength(1);j++)
array[i,j] = new Random().Next(-10,11);
}


void PrintArray(int[,] array)
{;
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}Console.WriteLine();}



void SumRowArray(int[,] array)
{ 
int s =0;
for (int i = 0; i < col; i++)
{ s = 0;
for (int j = 0; j < row; j++)
{
s += array [i,j];
sum[i] = s;
}}
}


void MinSumRowArray(int[] sum)
{ int  min = sum[0], r = 1;
for (int i = 0; i < row; i++)
{ if (min > sum[i]){
min = sum[i]; r = (i+1);
}}
Console.WriteLine();
Console.WriteLine("Минимальная ссумма элементов строки " + min + " и находится в " + r + " строке.");}
*/



/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


/*
Console.WriteLine("Введите размерность матрицы");
int row = Convert.ToInt32(Console.ReadLine());
int col = row;
int [,] matr1 = new int[row,col];
int [,] matr2 = new int[row,col];
int [,] matrx = new int[row,col];


void FillMatr1(int[,] matr1)
{
for (int i=0;i<matr1.GetLength(0);i++)
for (int j=0;j<matr1.GetLength(1);j++)
matr1[i,j] = new Random().Next(-10,11);
}


void FillMatr2(int[,] matr2)
{
for (int i=0;i<matr2.GetLength(0);i++)
for (int j=0;j<matr2.GetLength(1);j++)
matr2[i,j] = new Random().Next(-10,11);
}


void PrintMatr1(int[,] Matr1)
{Console.WriteLine("Первая матрица");;
for (int i=0;i<matr1.GetLength(0);i++)
{
for (int j=0;j<matr1.GetLength(1);j++)
Console.Write($"{matr1[i,j],3} \t");
Console.WriteLine();
}Console.WriteLine();}


void PrintMatr2(int[,] Matr2)
{Console.WriteLine("Вторая матрица");;
for (int i=0;i<matr2.GetLength(0);i++)
{
for (int j=0;j<matr2.GetLength(1);j++)
Console.Write($"{matr2[i,j],3} \t");
Console.WriteLine();
}Console.WriteLine();}


FillMatr1(matr1);
FillMatr2(matr2);
PrintMatr1(matr1);
PrintMatr2(matr2);


 
for (int i = 0; i < row; i++)
{
for (int j = 0; j < col; j++)
{
matrx[i, j] = 0;
for (int k = 0; k < row; k++)
{
matrx[i, j] += matr1[i, k] * matr2[k, j];
}}}


PrintMatrx(matrx);

void PrintMatrx(int[,] Matrx)
{Console.WriteLine("Произведение матриц");;
for (int i=0;i<matrx.GetLength(0);i++)
{
for (int j=0;j<matrx.GetLength(1);j++)
Console.Write($"{matrx[i,j],3} \t");
Console.WriteLine();
}Console.WriteLine();}
*/


/*
Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
Console.WriteLine("Введите размеры массива через пробел: ");
string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), }, 10, 99);
PrintArray(array);

int[,,] GetArray(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}


        bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
*/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
*/
using System;

class Program {
  public static void Main (string[] args) {
    /*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/
Console.WriteLine($"Введите размер матрицы: ");
    int s = int.Parse(Console.ReadLine());
    int[,] arr = GetArray(s);
    PrintArray(arr);


    int[,] GetArray(int size)
    {
      int [,] result = new int[size, size];
      int i = 0;
      int j = 0;
      int rowE = size - 1;
      int columnE = size - 1;
      int rowS = 0;
      int columnS = 0;
      bool left = true;
      bool top = true;
      int count = 0;
      while (count < size * size)
      {
        count++;
        result[i, j] = count;
        //идем вправо
        if (left && top)
        {
          if (j == columnE)
          {
            rowS++;
            top = true;
            left = false;
            i++;
            continue;
          }
          else
          {
            j++;
              continue;
          }
        }
        //идем вниз
        if (!left && top)
        {
          if (i == rowE)
          {
            columnE--;
            top = false;
            left = false;
            j--;
            continue;
          }
          else
          {
            i++;
            continue;
          }
        }
        //идем влево
        if (!left && !top)
        {
          if (j == columnS)
          {
            rowE--;
            top = false;
            left = true;
            i--;
            continue;
          }
          else
          {
            j--;
            continue;
      }
    }
        //Идем вверх
       if (left && !top)
        {
          if (j == rowS)
          {
            columnS++;
            top = true;
            left = true;
            j++;
            continue;
          }
          else
          {
            i--;
            continue; 
          }
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
          Console.WriteLine($"{inArray[i, j]} ");
        }
        Console.WriteLine();
      }
    }
  }
}