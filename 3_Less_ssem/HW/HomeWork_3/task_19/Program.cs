//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

void PalNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine("Это палиндром");
  }
  else Console.WriteLine("Нe палиндром");
}

if (number.Length == 5){
  PalNumber(number);
}
else 
Console.WriteLine($"Введи правильное число");