// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

NaturalNumbers();

Console.WriteLine();

// Метод подсчета натуральных чисел в диапазоне от M до N
void NaturalNumbers()
{   
    Console.WriteLine("Задайте значение М:");
    int m = SetNumber(Console.ReadLine());

    Console.WriteLine("Задайте значение N:");
    int n = SetNumber(Console.ReadLine());
    if (m < n)
    {
        int res = n - m;
        int[] array = new int[res + 1];
        int i = 0, num = m;
        
        while (num <= n)
        {
            array[i] = num;
            // if (m == n)
            // {
            //     Console.Write($"{m}");
            // }
            // else
            // {
            //     Console.Write($"{m}, ");
            // }
            num = num+1;
            i++;
        }
        Console.Write($"Натуральные числа от M = {m} до N = {n} это: {String.Join(", ",  array)}");
    }
    else
    {
        Console.WriteLine("Такой диапазан не предусмотрен задачей.");
    }
}

// Метод для определения числа
int SetNumber(string data)
{
    int number;

    while (true)
    {
        if (int.TryParse(data, out number))
        {   
            if(number > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Не натуральное число. Введите число: ");
                data = Console.ReadLine();
            }
            
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите число: ");
            data = Console.ReadLine();
        }
    }

    return number;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[{array[i]}] ");
    }
}