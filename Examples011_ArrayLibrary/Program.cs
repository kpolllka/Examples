//сделать заполнение массива на 10 индексов рандомными числами
//и вывести его на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        //index = index + 1;
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
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

int[] array = new int[10];

FillArray(array);
array[4] = 4; //принудительно добавили число 4 на 4ю и 6ю позиции массива
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
if (pos == -1)
{
    Console.WriteLine("Запрашиваемое число отсутствует в массиве");
}
else Console.WriteLine(pos);