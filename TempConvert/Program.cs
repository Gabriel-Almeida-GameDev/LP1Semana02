using System;
using System.Collections;
using System.Net;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Temperature: ");
            string Temp1 = Console.ReadLine();
            double Temp2 = Convert.ToDouble(Temp1);

            Console.Write("Unit (C/F): ");
            string Mode = Console.ReadLine();

            double calc1 = Temp2;
            double calc2 = Temp2;
            
            //C -> F
            double Result1 = calc1 * 1.8 + 32;
            double Absoluto1 = Math.Abs(Result1);

            //F -> C
            double Result2 = (calc2 - 32) / 1.8;
            double Absoluto2 = Math.Abs(Result2);
            

            switch (Mode)
            {
                case "C":
                    Console.WriteLine($"{calc1:f2} C = {Result1:f2} F");
                    Console.WriteLine($"Absolute value: {Absoluto1:f2}");
                    break;

                case "F":
                    Console.WriteLine($"{calc2:f2} F = {Result2:f2} C");
                    Console.WriteLine($"Absolute value: {Absoluto2:f2}");
                    break;
            }
        }
    }
}
