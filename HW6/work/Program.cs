// Метод, который выбирает задачи
void EnterTask()
{
    Console.WriteLine("Добро пожаловать в домашнее задание №6");
    Console.WriteLine("Укажите номер задачи, которую нужно выполнить:");
    Console.WriteLine("1 - первая задача, 2 - вторая задача, 0 - завершить работу");

    string task = Console.ReadLine();
    int num;

    while (true)
    {
        if(int.TryParse(task, out num) && num == 1)
        {
            Console.WriteLine("Выполняется задача 1");
            CounterPositiveNumbers();
            break;
        }
        else if(int.TryParse(task, out num) && num == 2)
        {
            Console.WriteLine("Выполняется задача 2");
            break;
        }
        else if(int.TryParse(task, out num) && num == 0)
        {
            Console.WriteLine("Работа программы завершена. Удачи!");
            break;
        }
        else
        {
            Console.WriteLine("Ошибка. Укажите номер задачи: 1, 2 или 0, чтобы выйти");
            task = Console.ReadLine();
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
                    // input = Console.ReadLine();
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


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
