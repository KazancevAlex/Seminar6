// Домашнее задание 41

Console.Clear();
Console.Write("сколько чисел будет введено: ");
int M = Convert.ToInt32(Console.ReadLine());

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());

}

void PrintArray(int[] array)
{
    Console.Write($"[{string.Join(",", array)}]");
}

int[] arr = new int[M];
Console.WriteLine("Введите числа: ");
InputArray(arr);
PrintArray(arr);

void PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
    count++;
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}

Console.WriteLine();
PositiveNumber(arr);