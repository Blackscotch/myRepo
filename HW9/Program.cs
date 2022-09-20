// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();
NaturalNumbers();
Console.ReadLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
SumNaturalNumbers();
Console.ReadLine();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
AkkermanFunction();

// Метод где принимаем значения и вычияляем функцию
void AkkermanFunction()
{
    Console.WriteLine("Вычислим функцию Аккермана для малых чисел. При значении m = 4 и n = 1 - переполнение стека");

    string end = "конец", input = String.Empty;

    while (end != input.ToLower())
    {
        Console.WriteLine("Задайте число m:");
        ulong m = Convert.ToUInt64(SetNumberForAkkerman(Console.ReadLine()));

        Console.WriteLine("Задайте число n:");
        ulong n = Convert.ToUInt64(SetNumberForAkkerman(Console.ReadLine()));

        ulong result = A(m, n);

        Console.WriteLine($"A({m}, {n}) = {result}");

        Console.WriteLine("Для введения новых чисел - Enter, для выхода - 'конец'.");
        input = Console.ReadLine();
    }
}

// Вычисление самой функции
ulong A(ulong m, ulong n)
{
    // Попробуем записать условия из формулы 
    // A(m,n) =: если м = 0, то n = (n + 1).
    // если m > 0 и n = 0, то A(m - 1, n + 1)
    // если m > 0 и n > 0, то A(m - 1, A(m, n - 1))

    if (m == 0) return n + 1;
    else if(m > 0 && n == 0) return A(m - 1, n + 1);
    else return A(m - 1, A(m, n - 1));
}

// Метод подсчета суммы натуральных чисел в диапазоне от M до N
void SumNaturalNumbers()
{
    Console.WriteLine("Считаем сумму натуральных чисел в диапазоне от M до N");
    Console.WriteLine("Задайте значение М:");
    int m = SetNumber(Console.ReadLine());

    Console.WriteLine("Задайте значение N:");
    int n = SetNumber(Console.ReadLine());

    if (m < n)
    {
        int i = m, num = m, result = 0;
        
        while (i <= n)
        {
            result += num;
            num++;
            i++;
        }
        Console.Write($"Сумма натуральных чисел M = {m} и N = {n} это: {result}");
        
    }
    else
    {
        Console.WriteLine("Такой диапазан не предусмотрен задачей.");
        
    }
}

// Метод подсчета натуральных чисел в диапазоне от M до N
void NaturalNumbers()
{   
    Console.WriteLine("Считаем натуральные числа в диапазоне от M до N");
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

// Метод для определения числа больше 0
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

// Метод для определения числа больше или равного 0 и меньше 6
int SetNumberForAkkerman(string data)
{
    int number;

    while (true)
    {
        if (int.TryParse(data, out number))
        {   
            if(number >= 0 && number < 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Число слишком велико или отрицательно. Введите число: ");
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