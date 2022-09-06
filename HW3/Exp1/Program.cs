using System;
namespace Mymetods
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            // 14212 -> нет
            // 12821 -> да
            // 23432 -> да


            // Тут метод работает через массив и принимает любое число до 10 знаков
            void Palindrom(string? data)
            {
                int lenght, new_number, number;

                while(true)
                {
                    if(int.TryParse(data, out number))
                    {
                        
                        if(number < 0)
                        {
                            lenght = data.Length - 1;
                        }
                        else
                        {
                            lenght = data.Length;
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Введите число");
                        data = Console.ReadLine();
                    }
                }

                if(number >=0 && number < 10 || number <= 0 && number > -10)
                {
                    Console.WriteLine($"Введенное число {number} не может быть палиндромом.");        
                }
                else
                {
                    int abs_number = Math.Abs(number);
                    
                    void GetMass(int[] array){

                        int abs_num = Math.Abs(number);
                        
                        array[0] = abs_num % 10;

                        int i;
                        for(i = 1; i < lenght; i++)
                        {
                            array[i] = (abs_num /= 10) % 10;
                        }
                    }
                    
                    int[] mass = new int[lenght];

                    GetMass(mass);

                    new_number = 0;

                    for(int i = 0; i < lenght; i++)
                    {
                        new_number += mass[i] * Convert.ToInt32(Math.Pow(10, lenght-i-1));
                    }

                    if(abs_number == new_number)
                    {
                        Console.WriteLine($"Число {number} - это палиндром.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {number} - это не палиндром.");
                    }
                }
            }

            // Метод без массива, а просто с разворотом числа
            void Palnum(string? data)
            {
                int number, number2 = 0;

                while(true)
                {
                    if(int.TryParse(data, out number))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Введте число.");
                        data = Console.ReadLine();
                    }
                }

                int abs_num = Math.Abs(number);

                int len = (int)Math.Log10(abs_num) + 1;

                for(int i = 0; i < len; i++)
                {
                    number2 += (abs_num % 10) * Convert.ToInt32(Math.Pow(10, len-i-1));
                    abs_num /= 10;
                }

                int abs_num2 = Math.Abs(number);

                if(number2 == abs_num2)
                {
                    Console.WriteLine($"Число {number} - это палиндром (в другом методе)");
                }
                else
                {
                    Console.WriteLine($"Число {number} - это не палиндром (в другом методе)");
                }
            }

            Console.WriteLine("Введите число");
            Palindrom(Console.ReadLine());

            Console.WriteLine("Введите число");
            Palnum(Console.ReadLine());


            // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            // A (3,6,8); B (2,1,-7), -> 15.84
            // A (7,-5, 0); B (1,-1,9) -> 11.53
            // Формула: A (xa, ya, za) B (xb, yb, zb). AB = корень квадратный из (xb - xa) в квадрате + (yb - уa) в квадрате + (zb -za) в квадрате

            // Габиль, а можно вызывать пустой метод, который ничего не принимает? Просто вызывается и что-то делает??
            Coord3D();

            void Coord3D()
            {   
                int ax, ay, az, bx, by, bz;
                
                Console.WriteLine("Введите координату А(х):");
                ax = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату А(y):");
                ay = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату А(z):");
                az = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату B(х):");
                bx = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату B(y):");
                by = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату B(z):");
                bz = int.Parse(Console.ReadLine());        

                Console.WriteLine($"Вычислим рассотяние между точками А и В с координатами А({ax}, {ay}, {az}) и B({bx}, {by}, {bz})");

                double result = Convert.ToDouble(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)));

                Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(result, 2)}");
            }

            // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            // 3 -> 1, 8, 27
            // 5 -> 1, 8, 27, 64, 125

            void Qube(string? data)
            {
                int num, result = 1;
                while(true)
                {
                    if(int.TryParse(data, out num))
                    {   
                        Console.WriteLine($"Получили число {num}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Введите число");
                        data = Console.ReadLine();
                    }
                }

                Console.Write($"Кубы входящте в число {num}: ");

                for(int i = 1; i <= num; i++)
                {
                    result = (int)Math.Pow(i, 3);

                    if(i == num)
                    {
                        Console.Write(result);
                    }
                    else
                    {
                        Console.Write(result+", ");
                    }
                }
            }
            Console.WriteLine("Введите число");
            Qube(Console.ReadLine());
        }
    }
}
