// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите массив из 5 чисел чисел, по одному  числу");


int[] arr = new int[5];
void NewArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
    arr[i] = int.Parse(Console.ReadLine());
    }
}
NewArray(arr);
PrintArray(arr);
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", " );
    }
    
}




int NumberCount(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        count++;
    }
    return count;
}


Console.WriteLine($"Введено чисел больше 0: {NumberCount(arr)} ");