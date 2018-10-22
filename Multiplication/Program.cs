using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Ingrese un numero");
            int a = Int32.Parse(Console.ReadLine());

            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine($"{a} X {i} = {a*i}");
            }
            Console.ReadKey();
        }
    }
}
