using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayHello();
            //sayHello("test");
            //sayHello(message2: "test2");
            

            int x = 10;
            int y = 15;

            //refMethod(ref x, y);
            //Console.WriteLine(x);
            //outInMethod(in x, y, out int z);
            //Console.WriteLine(z);

            Sum(1, 2, 3);
            int[] nums = { 1, 2, 3, 4, 5 };
            Sum(1, nums);
            Sum(0);

            Console.ReadKey();
        }

        static void sayHello(string message = "hello", string message2 = "test")
        {
            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.WriteLine("----------------");
        }

        static void refMethod(ref int x, int y)
        {
            x += y;
        }

        static void outInMethod(in int x, int y, out int z)
        {
            z = x + y;
        }

        static void Sum(int x, params int[] nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}

