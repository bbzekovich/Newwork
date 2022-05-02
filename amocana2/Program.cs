using System;

namespace amocana_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            var X = Convert.ToInt32(Console.ReadLine());
            var Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(X + Y);
            if (X > Y)
            {
                Console.WriteLine(X - Y);
            }
            else
            {
                Console.WriteLine(Y - X);
            }
            Console.WriteLine(X * Y);

            if (X > Y)
            {
                Console.WriteLine(X / Y);
            }
            else
            {
                Console.WriteLine(Y / X);
            }
            if (X == 0 || Y == 0)
            {
                Console.WriteLine($"X / Y not allowed to divide by zero");
            }



        }
    }
}
