// Дополнительное не обезательное
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
// 14 -> нет 46 -> нет 161 -> да

// Метод принимает на вход любое целое число (0-9 знаков), отрицательное и положительное
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

// Метод на кратность 7 и 23 или любым другим числам, которые укажем
void FindNumber(int data, int arg1, int arg2)
{   
    int res1 = data % arg1;
    int res2 = data % arg2;

    Console.WriteLine($"{res1} и {res2}");

    if(res1 == res2)
    {
        Console.WriteLine($"Число {data} кратно одновременно {arg1} и {arg2}");
    }
    else
    {
        Console.WriteLine($"Число {data} не кратно одновременно {arg1} и {arg2}");
    }
}

string? stop = "стоп", input = "";

while(stop != input?.ToLower())
{
    int num;

    Console.WriteLine("Введите целое число.");
    num = Input(Console.ReadLine());

    // меняя числа будем проверять кратность с ними
    FindNumber(num, 7, 23);

    Console.WriteLine("Напишите стоп для выхода или нажмите Enter для продолжения:");
    input = Console.ReadLine();
}