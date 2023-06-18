//Задайте значение N.Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии. N = 5 -> "5, 4, 3, 2, 1" N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1
/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = 5;
        PrintNaturalNumbers(n);
        // Output: 5, 4, 3, 2, 1
        Console.WriteLine();
        n = 8;
        PrintNaturalNumbers(n);
        // Output: 8, 7, 6, 5, 4, 3, 2, 1
    }

    public static void PrintNaturalNumbers(int n)
    {
        if (n == 1)
        {
            Console.Write(n);
        }
        else
        {
            Console.Write(n + ", ");
            PrintNaturalNumbers(n - 1);
        }
    }
}
*/
/*
 //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
 //элементов в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int m = 1;
        int n = 15;
        int sum = CalculateSum(m, n);
        Console.WriteLine(sum); // Output: 120

        m = 4;
        n = 8;
        sum = CalculateSum(m, n);
        Console.WriteLine(sum); // Output: 30
    }

    public static int CalculateSum(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
*/
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}"); // Output: A(2, 3) = 9

        m = 3;
        n = 2;
        result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}"); // Output: A(3, 2) = 29
    }

    public static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}