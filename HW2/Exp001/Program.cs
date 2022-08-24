// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Метод для проверки ввода на целое трехзначное число, преобразует строку из консоли в int
int EnterInput (string? data)
{
    string? arg = data;
    int number;
    while(true)
    {   
        if(int.TryParse(arg, out number))
        {
            if(number > 99 && number < 1000 || number < -99 && number > -1000)
            {
                Console.WriteLine($"Получено число {number}");
                break;
            }
            else
            {
                Console.WriteLine($"Получено число {number}, но оно не трехзначное.");
                Console.WriteLine("Введите целое трехзначное число.");
                arg = Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите целое число.");
            arg = Console.ReadLine();
        }
    }
    return number;
}

// Метод возвращает вторую цифру из числа и положително и отрицательного
int SecondDigit (int data)
{
    // Применил метод из справочника по C# для возврата абсолютного значения Math.Abs - не читерсво же?
    data = Math.Abs((data / 10) % 10);
    return data;
}

// Вот это - string? ставлю только потому, что ругается vs code. Оно не нужно, но сильно разражает (
string? stop = "стоп", input = "";

while(stop != input?.ToLower())
{
    int num, result;

    Console.WriteLine("Введите целое число:");
    num = EnterInput(Console.ReadLine());
    
    result = SecondDigit(num);

    Console.WriteLine($"Вторая цифра числа {num} - это {result}.");

    Console.WriteLine("Напишите стоп для выхода или нажмите Enter для продолжения:");
    input = Console.ReadLine();
}
