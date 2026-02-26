using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro:");
            string numero = Console.ReadLine();

            sbyte n = Convert.ToSByte(numero);

            Console.WriteLine("Decremento:");
            Console.WriteLine(--n);

            Console.WriteLine("Incremento:");
            Console.WriteLine(++n);

            Console.WriteLine("Com o número 127:");
            int experiencia = 127;
            sbyte n2 = Convert.ToSByte(experiencia);
            Console.WriteLine("Decremento:");
            Console.WriteLine(--n2);

            Console.WriteLine("Incremento:");
            Console.WriteLine(++n2);
        }
    }
}
