/*
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArray(int rows, int cols, int min, int max) {
    double[,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i, j] = new Random().Next(min, max) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        Console.Write("{ ");
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write("[" + array[i, j] + "] ");
        }
        Console.WriteLine("}");
    }
}


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимльное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мксимльное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] arr = CreateRandom2dArray(rows, cols, min, max);
PrintArray(arr);
*/

/*
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int cols, int min, int max) {
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        Console.Write("{ ");
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write("[" + array[i, j] + "] ");
        }
        Console.WriteLine("}");
    }
}

void SearchElArray(int[,] array, int pos1, int pos2){
    int num = -1;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(i + 1 == pos1 && j + 1 == pos2) num = array[i, j];
        }
    }
    if(num >= 0) Console.WriteLine($"Число на введенной позиции = {num}");
    else Console.WriteLine($"Введена некорректная позиция");
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимльное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мксимльное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateRandom2dArray(rows, cols, min, max);
PrintArray(arr);

Console.Write("Введите число для первой координаты: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для второй координаты: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
SearchElArray(arr, pos1, pos2);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateRandom2dArray(int rows, int cols, int min, int max) {
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        Console.Write("{ ");
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write("[" + array[i, j] + "] ");
        }
        Console.WriteLine("}");
    }
}

void AverCools(int[,] array) {
    double temp = 0;
    for(int i = 0; i < array.GetLength(1); i++){
        for (int j = 0; j < array.GetLength(0); j++) {
        temp += array[j,i];            
        }
        Console.Write(temp/array.GetLength(0) + " ");
        temp = 0;
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимльное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мксимльное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateRandom2dArray(rows, cols, min, max);
PrintArray(arr);
Console.WriteLine();
AverCools(arr);
