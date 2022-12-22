string[] array = { "hello", "2", "world", ":-", "-2", "1587", "98", "ddwd9", "-ff" };
string[] mass = { };
int count = 0;

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
        Array.Resize(ref mass, count);
        mass[count - 1] = array[i];

    }
}
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Результат:");
PrintArray(mass);

