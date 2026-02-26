using System;
using System.Runtime.Intrinsics.X86;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Unidade de Temperatura");
            Console.Write("(C -> Celcius ou F Fahrenheit): ");
            string Mode = Console.ReadLine();

            Console.Write("Temperatura: ");
            string Temp = Console.ReadLine();

        }
    }
}
