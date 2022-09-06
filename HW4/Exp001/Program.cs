// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите первое число: ");
int num1 = Input(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Input(Console.ReadLine());

// Реpультат метода с return и int
int result = Degree(num1, num2);

Console.WriteLine($"Число {num1} в степени {Math.Abs(num2)} равно {result}");

MathD(num1, num2);

// В методе проверка ввода
int Input(string? cons)
{
    int num;
    while(true)
    {
        if(int.TryParse(cons, out num))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите число");
            cons = Console.ReadLine();
        }
    }
    return num;
}

// В методе цикл, возводящий в степень
int Degree(int a, int b)
{
    int abs_b = Math.Abs(b) - 1;
    int res = a;
    for(int i = 1; i <= abs_b; i++)
    {
        res*=a;
    }
    return res;
}

// Метод через Math.Pow и ulong
void MathD(int arg1, int arg2)
{
    int b_abs = Math.Abs(arg2);

    ulong result = Convert.ToUInt64(Math.Pow(arg1, b_abs));

    Console.WriteLine($"Число {arg1} в степени {b_abs} равно {result}. Второй метод.");
}