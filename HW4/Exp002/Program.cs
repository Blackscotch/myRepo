// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
Summ(Console.ReadLine());

void Summ(string? number)
{
    ulong num, first_num;
    while(true)
    {
        if (ulong.TryParse(number, out num))
        {   
            first_num = num;
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите число");
            number = Console.ReadLine();
        }
    }

    int len = (int)Math.Log10(num) + 1;
    int result = 0;

    for(int i = 0; i <= len; i++)
    {
        result += Convert.ToInt32(num % 10); 
        num/=10;
    }
    Console.WriteLine($"Сумма цифр в числе {first_num} равна {result}");
}