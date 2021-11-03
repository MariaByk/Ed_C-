void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9,10);       
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int SumK(int[] collection, int k)
{
    int count = collection.Length;
    int index = 0;
    int IndK1 = 0;
    int IndK2 = 0;
    int sum = 0;
    
    while (index < count)
    {
        if (collection[index] == k)
        {
            IndK1 = index;
            break;
        }
        index++;
    }
    while (index < count)
    {
        if (collection[index] == k)
        {
            IndK2 = index;
        }
        index++;
    }
    sum = IndK2 - IndK1-1;
    return sum;
}

int[] array = new int[10];

FillArray(array);
array[2] = 1;
array[7] = 1;
PrintArray(array);
Console.WriteLine();

int pos = SumK(array,1);
Console.WriteLine(pos);