using System;

class Program
{
    // Method to perform Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        // Traverse through all elements in the array
        for (int i = 0; i < n - 1; i++)
        {
            // Last i elements are already in place
            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j + 1])
                {
                    // Swap the elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Method to print the array
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Example array to sort
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Unsorted array:");
        PrintArray(arr);

        // Call BubbleSort method
        BubbleSort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }
}
