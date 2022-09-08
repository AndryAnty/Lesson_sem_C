// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = new int[122];
void RandomArray(int[] arr)
{
Random rand = new Random(); 
for(int i = 0; i < arr.Length; i++)
arr[i] = rand.Next(0, 9);
// Console.WriteLine("[{0}]", string.Join(", ", arr));
}

RandomArray(arr);


int count = 0;
foreach (int num in arr)

{
    if(num > 10 && num < 100);
    count++;
}
Console.WriteLine("", count); 


