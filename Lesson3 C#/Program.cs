// Задача 0 Цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j<= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


// Задача 1. Заменить в текста пробелы на черточки, 
//маленькие буквы "к" на большие, а большие "С" ма маленькие

// string text = "Прошу детей простить меня за то, "
//             +"что я посвятил эту книжку взрослому. "
//             +"Скажу в оправдание: этот взрослый — "
//             +"мой самый лучший друг.";

// string s = "qwerty"
//             012
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text [i] == oldValue) 
//         result = result + $"{newValue}";
//         else 
//         result = result + $"{text[i]}";
//     }


//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// string newText2 = Replace(newText, 'к', 'К');
// Console.WriteLine(newText2);
// Console.WriteLine();

// string newText3 = Replace(newText2, 'С', 'с');
// Console.WriteLine(newText3);


// Задача 2. Сортировка выбором

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j]< array[minPosition])
            minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array [minPosition];
        array [minPosition] = temporary;

    }
}
void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j]> array[maxPosition])
            maxPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array [maxPosition];
        array [maxPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
SelectionSort2(arr);

PrintArray(arr);