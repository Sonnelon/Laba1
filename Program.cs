using System;

    internal class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 1 чилсо");

        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите 2 чилсо");

        double b = double.Parse(Console.ReadLine());

        Sub(a, b); Del(a, b); Sum(a, b); Der(a, b);

    }

         
            static void Sub(double a, double b)
            {
                Console.WriteLine(a - b);
            }

            static void Del(double a, double b)
            {
                 Console.WriteLine(a/b);
            }
       
 
            static void Sum(double a, double b)
            {
                Console.WriteLine(a + b);
            }

            static void Der(double a, double b)
            {
                Console.WriteLine(Math.Pow(a,b));
            }
}


