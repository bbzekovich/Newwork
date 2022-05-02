using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter number");
            var X = Convert.ToInt32(Console.ReadLine());
            var Y = 5;

            if ((X % Y == 0))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }



        }



    }



}
