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
{ int  min = sum[1], r = 1;
for (int i = 1; i < row; i++)
{ if (min < sum[i]){
min = sum[i]; r = (i+1);
}}
for (int i=0;i<array.GetLength(0);i++)
{Console.Write($"{sum[i],3} \t");}
Console.WriteLine();
Console.WriteLine(r);
Console.WriteLine(min);}



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


