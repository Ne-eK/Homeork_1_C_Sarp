/*

*/
/*
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Задаем массив трехзначных чисел 
int[] CreateRandomArray (int size) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
// Метод для вывод мссива
void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
    Console.WriteLine();
}
// Метод для подсчета количества четных элементов
void CountChet(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в мссиве = {count}");
}

Console.Write("Введите размер массива: ");          // Запрашиваем размер массива
int size = Convert.ToInt32(Console.ReadLine());     // Ввод данных
int[] randomArray = CreateRandomArray(size);        // Заполняем массив трехзначными числами
PrintArray(randomArray);                            // Вывод массива
CountChet(randomArray);                             // Подсчет количества четных чисел
*/

/*
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Задаем массив размера size с минимальным и максимальным знчением введенными пользователем.
int[] CreateRandomArray (int size, int min, int max) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
// вывод массива
void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
    Console.WriteLine();
}
// Считем сумму элементов на нечетных позициях
void SumNechetPos(int[] array) {
    int res = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 > 0) res += array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res}");
}

Console.Write("Input size: ");                      // Запрашиваем размер массива
int size = Convert.ToInt32(Console.ReadLine());     // Ввод данных
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] randomArray = CreateRandomArray(size, min, max);        // Заполняем массив трехзначными числами
PrintArray(randomArray);                                      // Вывод массива
SumNechetPos(randomArray);                                    // Подсчет количества четных чисел
*/

/*
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Задаем массив размера size с минимльным и максимальным значением введенными пользователем.
int[] CreateRandomArray (int size, int min, int max) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
// Вывод массива
void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
    Console.WriteLine();
}
// Поиск максимльного значения
int MaxEl(int[] array) {
    int max = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (max < array[i]) max = array[i];
    }
    return max;
}
// Поиск минимального значения
int MinEl(int[] array) {
    int min = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (min > array[i]) min = array[i];
    }
    return min;
}


Console.Write("Input size: ");                                      // Запрос днных у пользователя
int size = Convert.ToInt32(Console.ReadLine());                     // Ввод данных
Console.Write("Input min < 0 : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max > 0 : ");
int max = Convert.ToInt32(Console.ReadLine());
if (min < 0 && max > 0) {                                           // Проверка ввденных значений на корректность
    int[] randomArray = CreateRandomArray(size, min, max);          // Задаем массив
    PrintArray(randomArray);                                        // Выводим массив
    int maxEl = MaxEl(randomArray);                                 // Ищем максимальное значение
    int minEl = MinEl(randomArray);                                 // Ищем минимальное значение
    Console.WriteLine($"Разница между минимльным и максимальным зачением массива равна: {maxEl - minEl}"); // вывод результата
}
else Console.WriteLine($"Введенные значения min и max  не соответсвуют условиям");  // Сообщение об ошибке
*/

