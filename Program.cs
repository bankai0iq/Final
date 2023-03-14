string[] array1 = new string[5] {"911", "98", "hello", "world", ":-)"};
string[] array3 = new string[5] { "911", "98", "hello", "world", ":-)" };
string[] array2 = new string[array1.Length];
int count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array2);