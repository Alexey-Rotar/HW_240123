// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Количество элементов - на выбор

// Создание и заполнение массива
int[] FillingArray(int n)
{
    Console.WriteLine($"Введите последовательно {n} значения(ий) массива:");
    int[] array = new int[n];
    for (int i=0; i<array.Length; i++)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
            array[i] = number;
        else
            Console.WriteLine("Некорректное значение!");
    }
    return array;
}

// Вывод массива
void OutputingArray(int[] array)
{
    Console.WriteLine("Сформированный массив:");
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
        if (i<array.Length-1) 
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}]");
            Console.WriteLine("");
}

Console.WriteLine("Укажите размер массива:");
if (int.TryParse(Console.ReadLine(), out int n))
{
    int[] createdArray = FillingArray(n);
    OutputingArray(createdArray);
}
else
    Console.WriteLine("Некорректное значение!");