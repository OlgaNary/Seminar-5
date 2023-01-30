// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(6);
PrintArray(arr);
System.Console.WriteLine($"сумма элементов, стоящих на нечетных позициях равна {GetSumNumOddPosition(arr)}");

// Метод создает рандомный одномерный массив чисел:
int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-99, 100);
    }
    return result;
}

// Метод выводит на печать заданный массив:
void PrintArray(int[] arr)
{
    System.Console.Write("В массиве: ");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

//Метод находит сумму элементов, стоящих на нечетных позициях:
int GetSumNumOddPosition(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += arr[i];
        }
    }
    return result;
}