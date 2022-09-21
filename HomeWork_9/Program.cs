/*
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NatureEl (int m, int n) {
    for(int i = m; i <= n; i++){
        Console.Write(i + ", ");
    }
}
Console.Write("Введите первое число для отсчета: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для отсчета: ");
int n = Convert.ToInt32(Console.ReadLine());
NatureEl(m, n);
*/

/*
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int NatureEl (int m, int n) {
    int sum = 0;
    for(int i = m; i <= n; i++){
        sum += i;
    }
    return sum;
}

Console.Write("Введите первое число для отсчета: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для отсчета: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = NatureEl(m, n);
Console.Write($"Сумма натуральных элементов в промежутке между {m} и {n} = {sum}");
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Aker(int m, int n) {
    if (m == 0){
        return n + 1;
    }
    else if((m > 0) && (n == 0)){
        return Aker(m - 1, 1);
    }
    else if((m > 0) && (n > 0)){
        return Aker(m - 1, Aker(m, n - 1));
    }
    else return n + 1;
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = Aker(m, n);
Console.Write($"Значение функции Акермана по заданным {m} и {n} = {sum}");