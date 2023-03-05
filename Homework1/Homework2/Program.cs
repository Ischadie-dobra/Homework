//Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number(int num)
{
   int hundreds = num % 100;
   int ones = hundreds / 10;
   
   return ones;
 }
   
Console.Write("Введите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number(num));



