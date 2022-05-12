using System;

namespace multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter your number,please");
            int i = Convert.ToInt16(Console.ReadLine());
            for ( i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    break;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    break;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    break;
                }
                else
                {
                    Console.WriteLine("%d/t", i);
                }
                }
                }
            }
        }
 
