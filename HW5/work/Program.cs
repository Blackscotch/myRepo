// Делаю все задачи в одном файле. Методы выполняются последовательно.

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// CountNumbers();

int CountNumbers()
{
    Console.WriteLine("Выполняется метот для нахождения количества четных чисел в массиве");

    Console.Write("Задайте размерность массива: ");
    int len = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    int[] mass = new int[len];

    int count = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(99, 1000);

        if (mass[i] % 2 == 0) count++;

    }
    
    Console.WriteLine($"В массиве {String.Join(", ", mass)} количество положительных чисел = {count}");
    return count;

}


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// SummElements();

int SummElements()
{
    Console.WriteLine("Выполняется метот для нахождения суммы элементов на нечетных индексах");

    Console.Write("Задайте размерность массива: ");
    int len = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    int summ = 0;

    int[] mass = new int[len];

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-99, 100);

        if (i % 2 != 0)
        {
            summ+=mass[i];
        }
    }

    Console.WriteLine($"Массив {String.Join(", ", mass)}");
    Console.WriteLine($"Сумма нечетных элементов =  {summ}");

    return summ;

}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// ProductNumbers();

int[] ProductNumbers()
{
    Console.WriteLine("Выполняется метот для нахождения произведения зеркальных элементов массива");

    Console.Write("Задайте размерность массива: ");
    string? read = Console.ReadLine();
    int len;

    // Вот тут проверим какой размерности будет массив.
    // Можем принять любое число, но сделаем его положительным.
    // При 0 - будем просить указать другую размерность
    while(true)
    {
        if(int.TryParse(read, out len) && len != 0)
        {
            len = Math.Abs(len);
            break;
        }
        else
        {
            Console.WriteLine($"Размерность массива = 0 или ошибка ввода.");
            Console.Write("Введите размерность: ");
            read = Console.ReadLine();
        }
    } 

    int[] mass = new int[len];

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(1,10);
    }

    Console.WriteLine($"Массив A: {String.Join(", ", mass)}");

    // Пересчитаем размерность второго массива, т.к. она всегда будет меньше размерности первого
    // А также если она нечетная, прибавим + 1 элемент
    int new_len;
    if(len % 2 == 0)
    {
        new_len = len / 2;
    }
    else
    {
        new_len = (len / 2) + 1;
    }

    // Объявим новый массив с новой размерностью
    int[] new_mass = new int[new_len];

    for (int i = 0; i < new_len; i++)
    {
        // Вот здесь мы умножаем первый и последний элементы
        new_mass[i] = mass[i] * mass[mass.Length - 1 -i];

        // А здесь если размерность массива 1 или счетчик равен индексу последнего элемента - умножение не делаем
        if (i == new_len - 1)
        {
            new_mass[i] = mass[i];
        }
    }

    Console.WriteLine($"Массив B: {String.Join(", ", new_mass)}");

    // Вернем новый массив
    return new_mass;
}

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

// Вещественные числа соответсвуют double

NamberDiference();

double NamberDiference()
{
    Console.WriteLine("Выполняется метот для нахождения разницы между мин и макс элементами в массиве");

    Console.Write("Задайте размерность массива: ");
    string? read = Console.ReadLine();
    int len;

    while(true)
    {
        if(int.TryParse(read, out len) && len > 1)
        {
            len = Math.Abs(len);
            break;
        }
        else
        {
            Console.WriteLine($"Размерность массива меньше 2 или ошибка ввода.");
            Console.Write("Введите размерность: ");
            read = Console.ReadLine();
        }
    }

    double[] mass = new double[len];

    double max = mass[0];
    double min = mass[0];

    for (int i = 0; i < len; i++)
    {
        mass[i] = Convert.ToDouble(new Random().Next(0, 100));
        
        if(mass[i] > max)
        {
            max = mass[i];

            if(mass[i] < min)
            {
                min = mass[i];
            }
        }
    
    }
    double result = max - min;
    Console.WriteLine($"Массив: {String.Join(", ", mass)} и мин = {min}, макс = {max}");
    Console.WriteLine($"Разница между {max} и {min} = {result}");

    return result;
}
