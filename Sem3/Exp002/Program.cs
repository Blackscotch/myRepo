using System;

namespace Seminar3
{
    class TestMetods
    {
        public static void Main(string[] args)
        {
            // Напишите программу, которая
            // принимает на вход координаты двух точек и
            // находит расстояние между ними в 2D пространстве.
            // A (xa, ya) B (xb, yb). AB = корень квадратный из (xb - xa) в квадрате + (yb - уa) в квадрате
            // A (xa, ya, za) B (xb, yb, zb). AB = корень квадратный из (xb - xa) в квадрате + (yb - уa) в квадрате + (zb -za) в квадрате
            // A (3,6); B (2,1) -> 5,09
            // A (7,-5); B (1,-1) -> 7,21

            void Coordinate(string? data)
            {
                int[] a = new int[2];
                int[] b = new int[2];
                int number;

                void FillArray(int[] collection)
                {
                    int length = collection.Length;
                    int index = 0;

                    while(index < length)
                    {
                        while(true)
                        {
                            if(int.TryParse(data, out number))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода. Введите координнату");
                                data = Console.ReadLine();
                            }
                        }
                        collection[index] = number;
                        Console.WriteLine($"Записали число {collection[index]} в массив с индексом {index}");
                        index++;

                        if(index != length)
                        {
                            Console.WriteLine($"Введите координату Y:");
                            data = Console.ReadLine();
                        }
                    }
                }
                
                FillArray(a);

                Console.WriteLine("Введите координату X:");
                data = Console.ReadLine();
                FillArray(b);

                Console.WriteLine($"Начиначем вычислять расстояние точек A и B, где xa = {a[0]}, ya = {a[1]}, xb = {b[0]}, yb = {b[1]}");
                double coordinate = Convert.ToDouble(Math.Sqrt((Math.Pow(b[0] - a[0], 2)) + (Math.Pow(b[1] - a[1], 2))));
                Console.WriteLine($"Расстояние между точками A и B составляет {Math.Round(coordinate, 3)}");
            }

            Console.WriteLine("Вычислим расстояние между точками. Введите координаты для точек A и B");
            Console.WriteLine("Введите координату X:");
            Coordinate(Console.ReadLine());
        }
    }
}
