//  Задайте одномерный массив, заполненный случайными числами 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];
void RandomArray(int[] arr)
{
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    arr[i] = rand.Next(10);
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

int sum = 0;
void SummElement(int sum)
{
    for(int num = 0; num < arr.Length; num++)
    if(arr[num] % 2 > 0)
    sum = sum + arr[num];
    Console.WriteLine($"Сумма нечетных эллементов в массиве из {arr.Length} элементов = {sum}");;
}

RandomArray(arr);
SummElement(sum);