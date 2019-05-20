using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Display(nameof(Solutions.Solution1), Solutions.Solution1(1000));
            Display(nameof(Solutions.Solution2), Solutions.Solution2(4000000));
            Console.ReadLine();
        }

        static void Display<T>(string name, T result)
        {
            Console.WriteLine($"{name}: {result}");
        }
    }
}
