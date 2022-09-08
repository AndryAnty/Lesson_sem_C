// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] arr = new int[10];
RandomArray(arr);
NegativeArray(arr);


void RandomArray(int[] arr)
{
Random rand = new Random();
for(int i = 0; i < arr.Length; i++)
arr[i] = rand.Next(-10, 10);
Console.WriteLine("[{0}]", string.Join(", ", arr));
}

void NegativeArray(int[] arr)
{
for(int i = 0; i < arr.Length; i++)
    {
    arr[i] = arr[i] * -1;
    }
Console.WriteLine("[{0}]", string.Join(", ", arr));
}


