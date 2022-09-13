// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Сразу запишем результат метода в новый массив, он понадобится далее
double[,] mass = GetArray();
Console.WriteLine();

double[,] GetArray()
{
    Console.Clear();
    Console.WriteLine("Задача 47. Задаем двумерный массив размером m×n");

    Console.WriteLine("Задайте количество строк массива:");
    int m = SetNumber(Console.ReadLine());

    Console.WriteLine("Задайте количество столбцов массива:");
    int n = SetNumber(Console.ReadLine());

    double[,] arr = new double[m,n];

    Random numbers = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Math.Round(numbers.NextDouble() * (10 + 10) -10, 2);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

    return arr;
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задача 50. Примем на вход позиции элемента и найдем его, если он есть");

Console.WriteLine("Задайте позицию 1:");
int num1 = SetNumber(Console.ReadLine());

Console.WriteLine("Задайте позицию 2:");
int num2 = SetNumber(Console.ReadLine());

// Все данные есть, подрубаем метод
FillPosition(mass, num1, num2);

void FillPosition(double[,] array, int pos1, int pos2)
{
    bool result = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write($"[{array[i, j]}] ");
            if(i == pos1 && j == pos2)
            {
                result = true;
            }
        }
        Console.WriteLine();
    }

    if(result == true)
    {
        Console.WriteLine($"Элемент с позицией {pos1} и {pos2} найден. Его значение: {array[pos1, pos2]}");
    }
    else
    {
        Console.WriteLine($"Элемента с позицией {pos1} и {pos2} не существует.");
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

ArithmeticMean();

double[] ArithmeticMean()
{
    Console.Clear();
    Console.WriteLine("Задача 52. Найдем среднее арифметическое столбцов массива");

    Console.WriteLine("Задайте количество строк массива:");
    int m = SetNumber(Console.ReadLine());

    Console.WriteLine("Задайте количество столбцов массива:");
    int n = SetNumber(Console.ReadLine());

    // По условию у нас целочисленный массив, потому создадим
    int[,] arr = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(0, 11);
            Console.Write($"[{arr[i, j]}] ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    // Второй массив для сохранения значений дабл, т.к. находим среднее арифметическое
    // В первом for фиксируем столбец (n), а во втором бежим по строкам (m), записывая j элемент i столбца
    double[] mass = new double[n];

    for (int i=0; i < n; i++)
    {
        for(int j=0; j < m; j++)
        {
            mass[i] += arr[j, i];
        }
        mass[i] = Math.Round(mass[i] / m, 1);

        // Вот это интересная интреполяция. Не знал, что так можно)) уже 3-й способ интреполяции откапал.
        Console.WriteLine("Среднее арифметическое {0} столбца: {1}", i+1, mass[i]);
    }

    // Ну и последний for (лишний), но для ответа, как в задаче
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"[{mass[i]}] ");
    }
    return mass;
}

// Метод для определения числа
int SetNumber(string data)
{
    int number;

    while (true)
    {
        if (int.TryParse(data, out number))
        {
            // Т.к. в массиве не бывает отрицательной размерности и отрицательного индекса
            // все числа приведем к абсолюту
            number = Math.Abs(number);
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите число: ");
            data = Console.ReadLine();
        }
    }

    return number;
}