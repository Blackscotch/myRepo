using System;

namespace Seminar3
{
    internal class NewBaseType
    {
        public static void Main(string[] args){

            void NumberOfQart(string? data)
            {
                int quart;
                while (true)
                {
                    if (int.TryParse(data, out quart))
                    {
                        if (quart > 0 && quart < 5)
                        {
                            Console.WriteLine($"Введено число {quart}");
                            switch (quart)
                            {
                                case 1:
                                    Console.WriteLine($"В четверти {quart} возможные значения координат х и y от 0 до +бесконечность");
                                    break;

                                case 2:
                                    Console.WriteLine($"В четверти {quart} возможные значения координат х от 0 до -бесконечность и y от 0 до +бесконечность");
                                    break;

                                case 3:
                                    Console.WriteLine($"В четверти {quart} возможные значения координат х и y от 0 до -бесконечность");
                                    break;

                                case 4:
                                    Console.WriteLine($"В четверти {quart} возможные значения координат х от 0 до +бесконечность и y от 0 до -бесконечность");
                                    break;
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Указанной четверти не существует. Укажите четверть от 1 до 4");
                            data = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Введите число.");
                        data = Console.ReadLine();
                    }
                }
            }
            
            Console.WriteLine("Нужно ввести номер четверти (1 - 4)");
            NumberOfQart(Console.ReadLine());
        }
    }
}

