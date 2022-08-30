// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве, минимальное и максимальное значение.
// Надо заполнить массив рандоными данными от минимального до максимального значения.
// И важное уточнениее - делать все в методе который возвращает массив
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Запустим метод, который создаст массив из введенных данных.");
Console.WriteLine("Задайте длину массива(целое число): ");

// Вызовем метод
MyMass(Console.ReadLine());

int[] MyMass(string? data)
{
    int len, start, final;

    // Парсим в цикле ввод для всех данных: размерность массива, минимальное и максимальное значение элементов
    while(true)
    {
        if(int.TryParse(data, out len))
        {   
            len = Math.Abs(len);
            Console.WriteLine("Задайте Min элементов массива: ");
            data = Console.ReadLine();
            
            while(true)
            {
                if(int.TryParse(data, out start))
                {
                    Console.WriteLine("Задайте Max элементов массива: ");
                    data = Console.ReadLine();

                    while(true)
                    {
                        if(int.TryParse(data, out final))
                        {
                            while(final < start)
                            {
                                Console.WriteLine("Max меньше Min. Измените значение Max:");
                                data = Console.ReadLine();
                                while(true)
                                {
                                    if(int.TryParse(data, out final))
                                    {
                                        break;
                                    }
                                    else{
                                        Console.WriteLine("Ошибка ввода, задайте Max");
                                        data = Console.ReadLine();
                                    }
                                }
                            }
                            break;   
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода, задайте Max");
                            data = Console.ReadLine();
                        }
                    }
                    break;    
                }
                else
                {
                    Console.WriteLine("Ошибка ввода, задайте Min: ");
                    data = Console.ReadLine();
                }
            }
            break;   
        }
        else
        {
            Console.WriteLine("Ошибка ввода, задайте длину массива(целое число): ");
            data = Console.ReadLine();
        }
    }

    // Показываем, какие данные собрали
    Console.WriteLine($"Есть длина {len}, минимум {start} и максимум {final}");

    // Объявляем новый массив с размерностью len
    int[] array = new int[len];

    // Записываем значения элементов и отображаем массив в консоли
    Console.Write("Массив с элементами:");

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, final);

        // Убираем запятую для последнего индекса
        if(i == len - 1)
        {
            Console.Write($"[{array[i]}]");
        }
        else
        {
           Console.Write($"[{array[i]}],"); 
        }
        
    }

    return array;
}