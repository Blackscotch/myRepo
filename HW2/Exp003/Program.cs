// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Метод на прием числа от 1 до 7
int EnterNum (string? data)
{
    string? arg = data;
    int number;
    while(true)
    {   
        if(int.TryParse(arg, out number))
        {
            if(number >= 1 && number <= 7)
            {
                Console.WriteLine($"Получено число {number}");
                break;
            }
            else
            {
                Console.WriteLine($"Получено число {number}, но оно не соотв. условию.");
                Console.WriteLine("Введите число от 1 до 7.");
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

// Метод, определяющий выходной день
void IsDay (int data)
{   string info = "";
    switch (data)
    {
        case 6:
            info = $"День {data} - это суббота, он выходной.";
            break;  
        case 7:
            info = $"День {data} - это воскресенье, он выходной.";
            break;
        default:
            info = $"День {data} - не выходной.";
            break;
    }
    Console.WriteLine(info);
}
string? stop = "стоп", input = "";

while(stop != input?.ToLower())
{
    int day;

    Console.WriteLine("Введите число от 1 до 7.");
    day = EnterNum(Console.ReadLine());

    IsDay(day);

    Console.WriteLine("Напишите стоп для выхода или нажмите Enter для продолжения:");
    input = Console.ReadLine();
}
