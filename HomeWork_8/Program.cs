int[,] CreateRandom2dArray(int rows, int cols, int min, int max) {
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i, j] = new Random().Next(min, max + 1);
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

/*
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

int[,] SortRowsArray(int[,] array) {
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 1; j < array.GetLength(1); j++){
            for(int r = 0; r < array.GetLength(1) - j; r++) {
                if(array[i,r] < array[i,r + 1]) {
                    temp = array[i,r];
                    array[i,r] = array[i,r + 1];
                    array[i,r + 1] = temp;
                } 
            } 
        }
    }
    return array;
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
Console.WriteLine("------------------------------------------------------------");
int[,] arr2 = SortRowsArray(arr);
PrintArray(arr2);
*/


/*
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void SumRowsEl(int[,] array) {
    int temp = 0;
    int[] tempArr = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            temp += array[i,j];
        }
        tempArr[i] = temp;
        temp = 0;
    }
    int min = 0;
    for(int i = 0; i < tempArr.Length; i++){
            if(tempArr[i] < tempArr[min]) min = i;
    }
    min += 1;
    Console.WriteLine("Номер строки: " + min);
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
Console.WriteLine("------------------------------------------------------------");
SumRowsEl(arr);
*/

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Spiral(int rows, int cols){
    int num = 10;
    int[,] arr = new int[rows,cols];
    // заполняем периметр по часовой стрелке
    for(int i = 0; i < cols; i++){
        arr[0,i] = num;
        num++;
    }
    for(int j = 1; j < rows; j++){
        arr[j,cols-1] = num;
        num++;
    }
    for(int i = cols - 2; i >= 0; i--){
        arr[rows - 1, i] = num;
        num++;
    }
    for(int j = rows - 2; j > 0; j--){
        arr[j,0] = num;
        num++;
    }
    // периметр заполнен

    // заполняем внутреннюю часть
    int a = 1, b = 1;
    while (num < rows * cols){
        while(arr[a,b + 1] == 0){
            arr[a,b] = num;
            num++;
            b++;
        }
        while(arr[a + 1,b] == 0){
            arr[a,b] = num;
            num++;
            a++;
        }
        while(arr[a,b - 1] == 0){
            arr[a,b] = num;
            num++;
            b--;
        }
        while(arr[a - 1,b] == 0){
            arr[a,b] = num;
            num++;
            a--;
        }
    }
    // убираем 0 в конце
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if(arr[i,j] == 0) arr[i,j] = num;
        }
    }

    return arr;

}

Console.WriteLine("Введите квадратную матрицу");
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
if(rows == cols) {
    int[,] arr = Spiral(rows, cols);
    PrintArray(arr);
}
else Console.Write("Некорректный ввод");
