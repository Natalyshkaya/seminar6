// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateMassive(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    return array;
}

int CoantPositive(int[] array)
{
    int coant = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            coant++;
        }
    }
    return coant;
}

Console.WriteLine("Введите количество элементов массива");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = CreateMassive(m);
Console.WriteLine();
Console.WriteLine($"количество положительных чисел={CoantPositive(array)}");