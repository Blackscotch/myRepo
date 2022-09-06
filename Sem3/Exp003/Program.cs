using System;

namespace Mymetods
{
    class TestMetods
    {
        public static void Main(string[] args)
        {
            // Напишите программу, которая
            // принимает на вход число (N) и выдаёт таблицу
            // квадратов чисел от 1 до N.
            // 5 -> 1, 4, 9, 16, 25.
            // 2 -> 1,4

            void SqrtNumberTable(string? data)
            {
                int num, i;

                while(true)
                {
                    if(int.TryParse(data, out num))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Введите число");
                        data = Console.ReadLine();
                    }
                }

                Console.Write($"Есть число {num}, вот его таблица квадратов: ");

                if(num >= 0)
                {
                    for(i = 1; i <= num; i++)
                    {   
                        if(i != num){
                            Console.Write(Math.Pow(i, 2)+", ");
                        }
                        else
                        {
                            Console.Write(Math.Pow(i, 2));
                        }
                    }
                }
                else
                {
                    for(i = -1; i >= num; i--)
                    {   
                        if(i != num){
                            Console.Write($"{Math.Pow(i, 2)}, ");
                        }
                        else
                        {
                            Console.Write($"{Math.Pow(i, 2)}");
                        }
                    }
                }
            }

            Console.WriteLine("Укажите число: ");
            SqrtNumberTable(Console.ReadLine());
        }
    }
}
