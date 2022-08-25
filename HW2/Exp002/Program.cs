// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Метод для проверки ввода на целое число (от 0 до 9 цифр) с любым знаком. Не уверен, что это всецело вершает задачу
int Input (string? data)
{
    // string? arg = data;
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

string? stop = "стоп", input = "";

while(stop != input?.ToLower())
{
    int num, result;

    Console.WriteLine("Введите целое число:");
    num = Input(Console.ReadLine());
    result = Math.Abs(num);
    if(result > 999)
    {
        while(Math.Abs(result) > 999)
        {
            result /=10;
        }
        result = result % 10;
        Console.WriteLine($"Здесь число {result}");
    }
    else if(result >= 100 && result <= 999)
    {
       result = result % 10;
       Console.WriteLine($"Здесь число {result}");
    }
    else if(result < 100)
    {
        Console.WriteLine($"В числе {num} третьей цифры нет");
    }
    // result = (int)Math.Log10(Math.Abs(num)) + 1;

    Console.WriteLine("Напишите стоп для выхода или нажмите Enter для продолжения:");
    input = Console.ReadLine();
}
