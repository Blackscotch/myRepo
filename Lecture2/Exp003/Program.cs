// Определяем нужное число в массиве и его индекс
/*int[] array = {1, 20, 30, 32, 12, 50, 80, 93, -8, 50};
int n =  array.Length;
int find = 50;
int idx = 0;

while(idx < n)
{
    if(array[idx] == find)
    {
        Console.WriteLine($"Елемент со значением {find}, это {idx} элемент в массиве");
        break;
    }
    idx++;
}*/


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// Инициализируем новый массив с определенным количеством элементов
int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);

Console.WriteLine();

int pos = IndexOff(array, 444);
Console.WriteLine(pos);