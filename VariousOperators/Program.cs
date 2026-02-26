using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número não-inteiro negativo:");
            string numero = Console.ReadLine();
            byte n = byte.Parse(numero);

            Console.WriteLine("Metade:");
            Console.WriteLine(n / 2);

            Console.WriteLine("Shift left por 3:");
            Console.WriteLine(n << 3);

            Console.WriteLine("n XOR 6:");
            Console.WriteLine(n ^ 6);

            Console.WriteLine("Maior que 10?:");
            Console.WriteLine(n > 10);

        }
    }
}
