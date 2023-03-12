//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите первое число: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double B = Convert.ToInt32(Console.ReadLine());
double degree = 0;
{
    for(int i = 0; i < B; i++)
    {
     degree = Math.Pow(A, B);
    }
}
double result = degree;

Console.Write($"Число {A} в натуральной степени {B} равно {result}");





//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
int Sum(int number)
{
int sum = 0;
while(number > 0)
{
sum += number % 10;
number = number / 10;
}
return sum;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма чисел {number} = {sum}");
*/







/*
int numberlength;
int sum = 0;

for(int i = 0; i <= number.length; i++)
{
sum+=i;
}
return sum;


int result = Sum(number);
Console.WriteLine($"Сумма = {result}");

*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
Console.WriteLine("Введите размер массива:");
int len =  int.Parse(Console.ReadLine());
int[] arr = new int[len];
Console.WriteLine("Введите числа через пробел:");
string[] arrayNumber =  Console.ReadLine().Split(' ');
 
for (int i =0; i < arrayNumber.Length; i++)
{
    arr[i] = int.Parse(arrayNumber[i]);
}
Console.WriteLine($"[{string.Join(", ", arr)}]");
*/





