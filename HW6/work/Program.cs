// Метод, который выбирает задачи
void EnterTask()
{
    Console.Clear();
    Console.WriteLine("Добро пожаловать в домашнее задание №6");
    Console.WriteLine("Укажите номер задачи, которую нужно выполнить:");
    Console.WriteLine("1 - первая задача, 2 - вторая задача, конец - завершить работу");

    string task = Console.ReadLine();
    string end = "конец";
    int num;

    while (end != task.ToLower())
    {
        if(end != task.ToLower())
        {
            if(int.TryParse(task, out num) && num == 1)
            {
                Console.WriteLine("Выполняется задача 1");

                // Выполняется метод с последовательным вводом чисел
                CounterPositiveNumbers();

                // Метод с вводом чисел через запятую или пробел
                NewCounterPositiveNumbers();

                Console.WriteLine("Укажите номер задачи, которую нужно выполнить:");
                Console.WriteLine("1 - первая задача, 2 - вторая задача, конец - завершить работу");
                task = Console.ReadLine();
            }
            else if(int.TryParse(task, out num) && num == 2)
            {
                Console.WriteLine("Выполняется задача 2");
                FindPoint();

                Console.WriteLine("Укажите номер задачи, которую нужно выполнить:");
                Console.WriteLine("1 - первая задача, 2 - вторая задача, конец - завершить работу");
                task = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ошибка. Укажите номер задачи: 1, 2");
                task = Console.ReadLine();
            }
        }
    }
}

EnterTask();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CounterPositiveNumbers()
{
    Console.Clear();
    Console.WriteLine("Задача 41: вводите числа с клавиатуры, посчитаем сколько из них больше ноля.");
    Console.WriteLine("Для выхода из програмы введите - конец");
    string end = "конец", input = "";
    int counter = 0;

    while (end != input.ToLower())
    {
        double number;
        Console.Write("Введите число или выйдите: ");
        input = Console.ReadLine();

        if (end != input.ToLower())
        {
            while (true)
            {
                if (double.TryParse(input, out number))
                {
                    if(number > 0){
                        counter++;
                        Console.WriteLine($"Положительных чиcел: {counter}");
                    }
                    else
                    {
                        Console.WriteLine($"Положительных чиcел: {counter}");
                    }
                    break;  
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода.");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine($"Завершаем работу на счете - {counter}. Удачи!");
        } 
    }
}

void NewCounterPositiveNumbers()
{
    Console.Clear();
    Console.WriteLine("Задача 41: вводите числа с клавиатуры через запятую или пробел, посчитаем сколько из них больше ноля.");
    Console.WriteLine("Для выхода из програмы введите - конец");

    string end = "конец", input = "";

    while (end != input.ToLower())
    {
        Console.Write("Введите числа через запятую или пробел или выйдите: ");
        input = Console.ReadLine();

        if (input != end)
        {   
            // Инициализируем массив разделителей
            char[] separators = new char[] { ' ', ','};

            // Разбиваем строку по подстрокам в новом массиве и убирвем пустые подстроки
            string[] strMass = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Записываем длину массива в переменную
            int len = strMass.Length;

            double[] mass = new double[len];

            int counter = 0;
            
            // Пробегаемся по массиву и считаем положительные числа
            for (int i = 0; i < len; i++)
            {
                mass[i] = Double.Parse(strMass[i]);
                if (mass[i] > 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"В массиве {input} чисел больше 0: {counter}");
        }
    }
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindPoint()
{
    Console.Clear();
    Console.WriteLine("Задача 43: Программа, которая найдёт точку пересечения двух прямых");
    Console.WriteLine("Для выхода из програмы введите - конец, для продолжения - жмите enter");

    string end = "конец", input = "";

    while (end != input.ToLower())
    {
        Console.WriteLine("Введите число b1: ");
        double b1 = SetNumber(Console.ReadLine());

        Console.WriteLine("Введите число k1: ");
        double k1 = SetNumber(Console.ReadLine());

        Console.WriteLine("Введите число b2: ");
        double b2 = SetNumber(Console.ReadLine());

        Console.WriteLine("Введите число k2: ");
        double k2 = SetNumber(Console.ReadLine());

        Console.WriteLine($"Получили требуемые значения: {b1}, {k1}, {b2}, {k2}");

        //Если y = k1 * x + b1 и y = k2 * x + b2
        //То равносильно утверждать, что k1 * x + b1 = k2 * x + b2
        //Сократим уравнение (k1 - k2) * x = b2 - b1
        //И определим х ->  x = (b2 - b1) / (k1 - k2)
        //Тогда y = (k1*(b2-b1))/(k1-k2)+b1;

        if (b2 == b1 && k1 == k2)
        {
            Console.WriteLine("Расположение прямых полностью совпадает");
        }
        else if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = (k1*(b2-b1))/(k1-k2)+b1;
            Console.WriteLine($"Точки пересечения прямых: х = {x}, y = {y}");
        }

        Console.WriteLine("Для выхода из програмы введите - конец, для продолжения - жмите enter");
        input = Console.ReadLine();
    }
}

// Метод для определения числа
double SetNumber(string data)
{
    double number;

    while (true)
    {
        if (double.TryParse(data, out number))
        {
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