// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Задача №54");

int a = InputNumbers("Введите количество столбцов: ");
int b = InputNumbers("Введите количество строк: ");

int[,] Array = GetArray(a, b, -10, 10); 

PrintArray(Array);
Console.WriteLine("");
PrintArray(ArrayTurn(Array));

int[,] ArrayTurn(int[,] array)
{
    int temp = 0;
    {
        for(int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++){
               for(int k = j + 1; k < array.GetLength(1); k++){
                if (array[i, j]<array[i, k]){
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
                }
            }
        }
    }
    return array;
}
 
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write("{0,4}", $"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int x, int y, int minValue, int maxValue){
    int [,] result = new int[x,y];
    for(int i = 0; i < x; i++){
        for(int j = 0; j < y; j++){
            result[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return result;
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Задача №56");

int c = InputNumbers("Введите размер массива: ");

int[,] Array1 = GetArray(c, c, 0, 10);

PrintArray(Array1);
Console.WriteLine("");
ArraySum(Array1);

void ArraySum(int[,] array)
{
    int minRow = 0;
    int Sum = 0;
    int k = 0;

    for (int i = 0; i < array.GetLength(1); i++){

        minRow += array[0, i];
            }
        for(int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++){
                Sum += Array1[i, j];
                    }
                if(Sum < minRow){
                    minRow = Sum;
                    k = i;
        }
        Sum = 0;
    }
    Console.WriteLine($"{k+1} строка");
}
    
// Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Задача №58");

int d = InputNumbers("Введите размер массива: ");

int[,] Array2 = GetArray(d, d, 0, 10);
int[,] secondArray = GetArray(d, d, 0, 10);

PrintArray(Array2);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
PrintArray(resultTurn(Array2));

int[,] resultTurn(int[,] Array2){
int [,] resultArray = new int[d, d];
for (int i = 0; i < Array2.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < Array2.GetLength(1); k++)
        {
            resultArray[i, j] += Array2[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray; 
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Задача №60");
Console.WriteLine($"Введите размер массива X x Y x Z:");

int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");

int[,,] array3D = new int[x,y,z];
GetArray3D(array3D);

Console.WriteLine($"");
PrintArray3D(array3D);

void PrintArray3D(int[,,] Array){      // Вывод массива на экран
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            for(int k = 0; k < Array.GetLength(2); k++){
                    Console.Write("{0,4}", $"{Array[i,j,k]}{(i, j, k)} ");
            }
        }
        Console.WriteLine();
    }
}


int[,,] GetArray3D(int[,,] array3D){
    // Создание одномерного массива заполненный рандомными числами 
    int [] array = new int[array3D.GetLength(0)*array3D.GetLength(1)*array3D.GetLength(2)];{
    for(int x = 0; x < array.GetLength(0); x++){
        array[x] = new Random().Next(10,100);
        if(x>=1){
            for (int j = 0; j < x; j++){
                while (array[x] == array[j]){
                array[x] = new Random().Next(10, 100);
                    }
                }
            }
        }
    }

// Заполнение трехмерного массива
    int count=0;
        for(int i = 0; i < x; i++){
        for(int j = 0; j < y; j++){
        for(int k = 0; k < z; k++){
            array3D[i,j,k] = array[count];
            count++; 
                }
            }
        }
    return array3D;
}

