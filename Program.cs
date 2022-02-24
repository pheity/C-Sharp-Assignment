using System;

namespace Pheity
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Poly Ilaro ";

            Console.Write("Enter Second Integer: ");
            int new_int = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Double: ");
            double new_double = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second String: ");
            string new_string = Console.ReadLine();

            Console.WriteLine(i + new_int);
            Console.WriteLine(d + new_double);
            Console.WriteLine(s + new_string);

        }
    }
}
