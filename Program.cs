//Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Number(int num)
{
   int hundreds = num % 100;
   int ones = hundreds / 10;
   
   return ones;
 }
   
Console.Write("Введите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number(num));

*/

//Task 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
int ThirdNumber(int num)
{
    while(num > 999)
    {
    num /= 10;
    }
    return num % 10;
}

bool ValidatNumber(int num)
{
    if(num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (ValidatNumber(num));
{
Console.WriteLine(ThirdNumber(num));
}
*/



//Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
/*
void IsDayWeek(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да, это выходной");
    }
    else
    if (number > 1 || number < 7)
    {
        Console.WriteLine("Нет, это не выходной");
    }

}

Console.Write("Input a day number: ");
int numb = Convert.ToInt32(Console.ReadLine());
IsDayWeek(numb);
*/
