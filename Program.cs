﻿internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 1 чилсо");

        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите 2 чилсо");

        double b = double.Parse(Console.ReadLine());

        Sum(a, b); 

    }
 
    static void Sum(double a, double b)
    {
        Console.WriteLine(a + b);
    }



}

