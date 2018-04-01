using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
            for (int j = 1; j < 101; j++)
            {
                if (j % 3 == 0 && j % 5 != 0 || j % 5 == 0 && j % 3 != 0) 
                {
                    Console.WriteLine(j);
                }
            }
            for (int k = 1; k < 101; k++)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine("Fizz"+ k);
                }
                if (k % 5 == 0)
                {
                    Console.WriteLine("Buzz" + k);
                }
                if (k % 3 == 0 && k % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
            for (int m = 1; m < 101; m++)
            {
                float num3 = m;
                float num5 = m;
                if (m/3 == num3/3)
                {
                    Console.WriteLine("Fizz m" + m);
                }
                if (m/5 == num5/5){
                    Console.WriteLine("Buzz m" + m);
                }
                if (m/3 == num3/3 && m/5 == num5/5)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
            Random var = new Random();
            for (int val = 0; val < 10; val++)
            {
                int rand = var.Next(1,100);
                if (rand % 3 == 0)
                {
                    Console.WriteLine("Fizz" + rand);
                }
                if (rand % 5 == 0)
                {
                    Console.WriteLine("Buzz" + rand);
                }
                
                if (rand % 5 == 0 && rand % 5 == 0)
                {
                    Console.WriteLine("FizBuzz" + rand);
                }
            }
        }
    }
}
