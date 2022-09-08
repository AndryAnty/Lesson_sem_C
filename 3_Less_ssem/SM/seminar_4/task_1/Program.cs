// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("введите a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b");
int b = Convert.ToInt32(Console.ReadLine());

Function(a, b);

void Function(int a, int b) 
{
    int count;
    for(count = 1; count < b; count++);
    {
        int result = Convert.ToInt32(Math.Pow(a, b));
        Console.WriteLine(result);
    }
}