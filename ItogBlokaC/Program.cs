string[] array = { "hello", "2", "world", ":-", "-2", "1587", "98", "ddwd9", "-ff" };
string[] mass = { };
int count = 0;
// печатаем массив
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
//заполняем массив mass 
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
        Array.Resize(ref mass, count); // увеличиваем размер массива до заданной величины (по факту на "1")
        mass[count - 1] = array[i];

    }
}
// передаем массивы на печать
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Результат:");
PrintArray(mass);

