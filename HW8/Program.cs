// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = GetArray(3,4, 0, 10);
Console.WriteLine("Массив рандомов для первой задачи");
PrintArray(arr);

int[,] mass = RegularizeArrayRows(arr);

Console.WriteLine("Отсортированный массив для первой задачи");
PrintArray(mass);

Console.ReadLine();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Массив рандомов для второй задачи");
arr = GetArray(5, 5, -10, 10);
PrintArray(arr);

int res = MinSummArrayElemets(arr);
Console.WriteLine($"Строка с наименьшей суммой: {res}");

Console.ReadLine();

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Создали 2 рандомные матрицы для третьей задачи");
arr = GetArray(2, 3, 1, 5);
int[,] arr2 = GetArray(3, 2, 1, 5);

// int[,] array1 = 
// {
//     {2,4},
//     {3,2}
// };
// int[,] array2 = 
// {
//     {3,4},
//     {3,3}
// };
PrintArray(arr);
PrintArray(arr2);


// Матрицу 1 можно умножить на матрицу 2 только если число столбцов матрицы 1 равняется числу строк матрицы 2, потому
if(arr.GetLength(1) == arr2.GetLength(0))
{
    Console.WriteLine("Результирующий массив");
    PrintArray(ResultMatrix(arr, arr2));
}
else
{
    Console.WriteLine("Такие матрицы умножить нельзя!");
}
Console.ReadLine();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Печатаем 3D массив для четвертой задачи");

int[,,] new3DArray = Get3DArray(2,2,2, -10, 10);
Print3DArray(new3DArray);

Console.WriteLine();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arrSpiral = SpiralArray(4,4);
PrintArray(arrSpiral);


// Метод создания массива
int[,] GetArray(int row, int col, int min, int max)
{
    int[,] array = new int [row, col];
    var random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

// Метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод упорядочивания элементов в строах
int[,] RegularizeArrayRows(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, k]) continue;
                var temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
   }
   return array;
}

// Метод для вычисления строки с наименьшей суммой
int MinSummArrayElemets(int[,] array)
{   
    int result = 0, sum = 0, count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (i == 0)
            {
                result += array[i,j];
            }
            sum += array[i,j];
        }
        Console.WriteLine(sum);
        if(sum < result)
        {
            result = sum;
            count = i;
        }
    }
    return count + 1;
}

// Метод, умножающий матрицы
int[,] ResultMatrix(int[,] array, int[,] array2)
{   
    int[,] resultArr = new int[array.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i,k] * array2[k,j];
            }
            resultArr[i,j] = sum;
        }
    }
    return resultArr;
}

// Метод создания трехмерного массива с уникальными значениями
int[, ,] Get3DArray(int x, int y, int z, int minRand, int maxRand)
{
    var random = new Random();
    int[] randomMass = new int[x * y * z];
    int unicNum;

    // Создадим массив с уникальными значениями
    for (int i = 0; i < randomMass.Length; i++)
    {
        randomMass[i] = random.Next(minRand, maxRand);
        unicNum = randomMass[i];

        if (i != 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (randomMass[i] == randomMass[j])
                {
                    randomMass[i] = random.Next(minRand, maxRand);
                    j = 0;
                    unicNum = randomMass[i];
                }
                unicNum = randomMass[i];
            }
        }
    }

    // Здесь трехмерный массив
    int[,,] array = new int [x,y,z];

    // Счетчик, позволящий заполнить массив значениями из массива выше
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = randomMass[count];
                count++;
            }
        }
    }
    return array;
}

// Метод печати 3D массива
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write( $"[{array[i,j,k]}] ({i}, {j}, {k}); ");
            }
            Console.WriteLine(); 
        }
        Console.WriteLine();
    }
}

// Метод спиральной записи данных в массив. Работает только для квадратных масивов , типа 4х4, 6х6 и т.д
int[,] SpiralArray(int row, int col)
{
    int[,] array = new int[row, col];
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= row * col)
    {
        array[i, j] = num;
        num++;

        if (i <= j + 1 && i + j < row - 1) j++;
        else if (i < j && i + j >= row - 1) i++;
        else if (i >= j && i + j > col - 1) j--;   
        else i--;   
    }
    return array;
}