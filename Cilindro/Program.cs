using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura do cilindro: ");
            string str_a = Console.ReadLine();
            double a = double.Parse(str_a);

            Console.Write("Raio do cilindro: ");
            string str_r = Console.ReadLine();
            double r = double.Parse(str_r);

            Console.Write("O volume do cilindro é: ");
            double V = Math.PI * Math.Pow(r, 2) * a;
            Console.WriteLine($"{V:f3}");

            Console.Write("A área da superfície do cilindro é: ");
            double Sa = 2 * Math.PI * r * (r + a);
            Console.Write($"{Sa:f3}");
        }
    }
}
