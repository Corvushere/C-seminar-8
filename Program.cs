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


FillArray(array);
Console.WriteLine("Начальный массив");
PrintArray(array);
SortRowArray(array);
Console.WriteLine("Отсортированный по убыванию массив");
PrintArray(array);
//PrintSum(sum);


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
{ int [] sum = new int[row];
int s =0;
for (int i = 0; i < col; i++)
{ s = 0;
for (int j = 0; j < row; j++)
{

s += array [i,j];

   
sum[i] = s;

Console.WriteLine("sum" + sum[i]);
Console.WriteLine("j" + i);
Console.WriteLine("s" + s);
}
}
for (int i=0;i<row;i++)
{
Console.Write("sumi" + sum[i]);
}
Console.WriteLine();
}

/*
void PrintSum(int[] sum)
{
for (int i=0;i<row;i++)
{
Console.Write($"{sum[i],3} \t");
Console.WriteLine();
Console.WriteLine();}}*/
