// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[10];
void RandomArray(int[] arr)
{
    
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    arr[i] = rand.Next(100,999);
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

int count = 0;
void Numbers(int count)
{
    
    for(int num = 0; num < arr.Length; num++)
    if(arr[num] % 2 == 0)
    count++;
    Console.WriteLine($"всего {arr.Length} чисел, из них {count} чётные числа");
}
RandomArray(arr);
Numbers(count);

