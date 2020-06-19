using System;

namespace Vivek
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, Sum;
            Console.WriteLine("Enter 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Sum = a + b;
            Console.WriteLine("Sum=" + Sum);
            Console.WriteLine("Sum={0}", Sum);
            Console.WriteLine("{0} + {1} = {2}", a, b, Sum);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
