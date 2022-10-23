using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 1 чилсо");

        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите 2 чилсо");

        double b = double.Parse(Console.ReadLine());

         Sub(a, b);


        static void Sub(double a, double b)
        {

            Console.WriteLine(a - b);

        }

    }
}
