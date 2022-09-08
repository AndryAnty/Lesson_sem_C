// Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] arr = new int[15];

void RandomArray(int[] arr)
{
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    arr[i] = rand.Next(-10, 10);
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}
RandomArray(arr);

int min = arr[0];
int max = min;



  for (int i = 1; i < arr.Length; i++)
  {
      if (arr[i] > max) max = arr[i];
      if (arr[i] < min) min = arr[i];
  }




Console.WriteLine($"Максимальное: {max} Минимальное: {min}");

int num = max - min;

Console.WriteLine($"Разница: {num}");