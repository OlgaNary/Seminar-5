//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] arr = GetRandomArray(6);
PrintArray(arr);
System.Console.WriteLine($"Максимальный элемент массива: {FindMaxNum(arr)}");
System.Console.WriteLine($"Минимальный элемент массива: {FindMinNum(arr)}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {FindMaxNum(arr) - FindMinNum(arr)}");

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

//Метод находит максимальный элемент массива:
int FindMaxNum(int[] arr)
{
    int maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxNumber < arr[i])
        {
            maxNumber = arr[i];
        }
    }
    return maxNumber;
}

//Метод находит минимальный элемент массива:
int FindMinNum(int[] arr)
{
    int minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minNumber > arr[i])
        {
            minNumber = arr[i];
        }
    }
    return minNumber;
}


