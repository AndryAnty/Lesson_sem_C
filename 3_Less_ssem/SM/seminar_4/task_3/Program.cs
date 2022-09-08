// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[7];
Random rand = new Random();
for(int i = 0; i < arr.Length; i++)
arr[i] = rand.Next();

PrintArray(arr);
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for(int j = 0; j < count; j++)
    {
        Console.Write($"{arr[j]} ");
    }
    Console.WriteLine();
}

