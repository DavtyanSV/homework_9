// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int Sum (int first, int second)
{
    if(first > second)
    {
        return 0;
    }
    int sum = 0;

    return sum+first + Sum(first+1,second);
}

System.Console.WriteLine(Sum(4,8));