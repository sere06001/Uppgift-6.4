using System;
using System.Collections.Generic;
namespace uppgift6_4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Bas?: ");
                double bas = double.Parse(Console.ReadLine());
                Console.Write("Exponent?: ");
                int exponent = int.Parse(Console.ReadLine());
                Console.WriteLine($"{bas}^{exponent} = {Potenser(bas, exponent)}");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static double Potenser(double bas, int exponent)
        {
            double produkt = 1;
            for (int i = 0; i < exponent; i++)
            {
                produkt *= bas;
            }
            return produkt;
        }
    }
}