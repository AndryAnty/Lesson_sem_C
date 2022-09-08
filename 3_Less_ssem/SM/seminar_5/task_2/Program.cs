// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да





Console.WriteLine("Играем в 'Угадай число'");
Console.WriteLine("Введите число от -5 до 5");

int[] arr = new int[5];
int num = Convert.ToInt32(Console.ReadLine());
void RandomArray(int[] arr)
{
Random rand = new Random();
for(int i = 0; i < arr.Length; i++)
arr[i] = rand.Next(-5, 5);
Console.WriteLine("[{0}]", string.Join(", ", arr));
}

void Examination(int num)
{
    if(arr.Contains(num))
    {
    
    Console.WriteLine("Число " + num + " в массиве присутствует!");
    }
    else Console.WriteLine("Числа " + num + " в массиве нет");
    }

RandomArray(arr);
Examination(num);




