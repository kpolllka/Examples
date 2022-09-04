// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find

int[] array = {61, 82, 93, 41, 55, 6, 93, 77, 83};

int n = array.Length;
int find = 93;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index ++;
}
