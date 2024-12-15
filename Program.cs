using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 4, 10, 3, 5, 1 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        HeapSort(array);

        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(array);
    }

    static void HeapSort(int[] array)
    {
        int n = array.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        for (int i = n - 1; i >= 0; i--)
        {
            Swap(array, 0, i);
            Heapify(array, i, 0);
        }
    }

    static void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            Swap(array, i, largest);
            Heapify(array, n, largest);
        }
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
