using System;

namespace amocana_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            var X = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10; i++)
                Console.WriteLine(X * i);
        }
    }
}
