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

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
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
    
