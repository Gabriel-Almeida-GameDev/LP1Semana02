using System;

namespace OperadoresEmInteiros
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int i1 = 3 ;
            Console.WriteLine(i1);

            int i2 = 1 ;
            Console.WriteLine(i2);

            int i3 = -8 ;
            Console.WriteLine(i3);

            int x = 2 ;
            Console.WriteLine(x);

            x = i1 - i3 ;
            Console.WriteLine(x);
            x = i3 / i1 ;
            Console.WriteLine(x);
            x += i2 ;
            Console.WriteLine(x);
            x *= i1 ;
            Console.WriteLine(x);
            x %= i2 - 0b1001 ;
            Console.WriteLine(x);
            x = i1 << 2 ;
            Console.WriteLine(x);
            x <<= x ;
            Console.WriteLine(x);
            x &= 0x21AD ^ i1 ;
            Console.WriteLine(x);
            x = ~(i1|i3) ;
            Console.WriteLine(x);
        }
    }
}
