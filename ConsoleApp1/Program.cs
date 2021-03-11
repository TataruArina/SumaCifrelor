using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Introdu numarul");
            int nr = int.Parse(Console.ReadLine());
            while (nr > 0)
            {
                int mod = (nr % 10);
                sum = (sum + mod);
                nr = (nr / 10);

            }
            Console.WriteLine("Suma cifrelor numarului este: {0}", sum);
            Console.ReadKey();
        }
    }
}
