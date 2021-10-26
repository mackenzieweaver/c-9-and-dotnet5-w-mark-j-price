using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint naturalNumber = 23;
            int integerNumber = -23;
            float realNumber = 2.3F;
            double anotherRealNumber = 2.3;
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"int uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"int uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue} to {decimal.MaxValue}");
        }
    }
}
