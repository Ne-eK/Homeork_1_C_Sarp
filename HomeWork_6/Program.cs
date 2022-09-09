/*
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Задаем метод для записи введенных чисел в массив
int[] ChisUser(int num) {
    int[] result = new int[num];
    for (int i = 0; i < num; i++) {
        Console.Write($"Введите {i + 1}-e число: ");
        result[i] = Convert.ToInt32(Console.ReadLine());       
    }
    return result;
}
// Выводим на экран положительные числа
void PrintUserArr(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        if(array[i] > 0) Console.Write($"{array[i]} ");
    }
}

Console.Write($"Какое количество чисел для которых требуется проверка на условие '> 0': "); // зпрос данных у пользователя
int num = Convert.ToInt32(Console.ReadLine());                                              // ввод данных
int[] res = ChisUser(num);                                                                  // сохраняем введенные значения в массив
Console.Write($"Числа подходящие под условие: ");                                           // Вывод значений
PrintUserArr(res);
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// 
/*

// метод для поиска точки пересечения
void PointIntersection(double b1, double k1, double b2, double k2) {
    double x = 0, y = 0;
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения = ({x}, {y})");
}

Console.Write("Введите значение точки b1 для певого уравнения: ");  // запрос данных у пользовтеля
double a = Convert.ToDouble(Console.ReadLine());                    // ввод данных
Console.Write("Введите значение точки k1 для певого уравнения: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки b2 для второго уравнения: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки k2 для второго уравнения: ");
double d = Convert.ToDouble(Console.ReadLine());

PointIntersection(a, b, c, d);                                       // вызов метода
*/