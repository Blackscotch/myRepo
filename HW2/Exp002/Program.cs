// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Метод для проверки ввода на целое число (от 0 до 9 цифр) с любым знаком. Не уверен, что это всецело решает задачу, 
// например с 10-значными числами и больше
int Input (string? data)
{
    int number;
    while(true)
    {   
        if(int.TryParse(data, out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите целое число.");
            data = Console.ReadLine();
        }
    }
    return number;
}

// Метод выведет последнюю цифру числа, в котором от 3 до 10 цифр
int LastNum (int data)
{
    if (data > 999)
    {
        while(data > 999)
        {
            data /= 10;
        }
        data = data % 10;
    }
    else
    {
        data = data % 10;
    }
    return data;
}

// Метод через логарифм. (int)Math.Log10() - вернет на 1 меньше, чем цифер в числе, потмоу + 1
int ElseNum(int data)
{
    int log = (int)Math.Log10(data) + 1;
    if(log > 3)
    {
        while(log > 3)
        {
            data /= 10;
            log--;
        }
        data = data % 10;
    }
    else
    {
        data = data % 10;
    }
    return data;
}

string? stop = "стоп", input = "";

while(stop != input?.ToLower())
{
    int num, result;

    Console.WriteLine("Введите целое число:");
    num = Input(Console.ReadLine());
    result = Math.Abs(num);

    if (result < 100)
    {
        Console.WriteLine($"В числе {num} третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"В числе {num} третья цифра это {LastNum(result)}");
        Console.WriteLine($"В числе {num} третья цифра это {ElseNum(result)} в другом методе");
    }

    Console.WriteLine("Напишите стоп для выхода или нажмите Enter для продолжения:");
    input = Console.ReadLine();
}
