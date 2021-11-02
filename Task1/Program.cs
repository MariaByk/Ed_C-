void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,15);       
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
int SumN(int[] collection, int n, int k, int l)
{
    int count = collection.Length;
    int index = 0;
    int sum = 0;
    
    while (index < count)
    {
        // if (collection[index] < n && (collection[index] % k == 0 | collection[index] % l == 0 ))
        if (collection[index] < n && !(collection[index] % (k+l) == 0))
        {
            sum++;
        }
        index++;
    }
    return sum;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = SumN(array, 13, 2, 4);
Console.WriteLine(pos);