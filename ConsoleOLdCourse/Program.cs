using System;

namespace ConsoleOLdCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = 0.000000000000000000000000000000000000000000000000000000000000000000000000000001;
            var t2 = 0.000000000000000000000000000000000000000000000000000000000000000000000000000001;

            var r = 2.ToString();

            Console.WriteLine($"Минимальное значение '{typeof(short)}': {short.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(short)}': {short.MaxValue}");
            Console.WriteLine($"Минимальное значение '{typeof(ushort)}': {ushort.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(ushort)}': {ushort.MaxValue}");

            Console.WriteLine($"Минимальное значение '{typeof(int)}': {int.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(int)}': {int.MaxValue}");
            Console.WriteLine($"Минимальное значение '{typeof(uint)}': {uint.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(uint)}': {uint.MaxValue}");

            Console.WriteLine($"Минимальное значение '{typeof(long)}': {long.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(long)}': {long.MaxValue}");
            Console.WriteLine($"Минимальное значение '{typeof(ulong)}': {ulong.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(ulong)}': {ulong.MaxValue}");

            Console.WriteLine($"Минимальное значение '{typeof(float)}': {float.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(float)}': {float.MaxValue}");

            Console.WriteLine($"Минимальное значение '{typeof(double)}': {double.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(double)}': {double.MaxValue}");

            Console.WriteLine($"Минимальное значение '{typeof(byte)}': {byte.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(byte)}': {byte.MaxValue}");

            Console.WriteLine($"Минимальное значение '{typeof(char)}': {char.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(char)}': {char.MaxValue}");

            Console.WriteLine($"Минимальное значение '{typeof(decimal)}': {decimal.MinValue}");
            Console.WriteLine($"Максимальное значение '{typeof(decimal)}': {decimal.MaxValue}");

            // Математические: + - * /
            /* Логические:
                - AND: &&
                - NOT: !<logical variable> 
                - OR: ||
                - Equal: ==
               Побитовые операции:
                - AND: &
                - NOT: !<logical variable> 
                - OR: |
                - XOR: ^

                AND 5: 0101
                    3: 0011
                       0001

                OR  5: 0101
                    3: 0011
                       0111  
             */

            var t = 5;
            var b = 2;
            var y = 4;

            var result = (t + b) / y;
            var result1 = (5 + 2) / 4;
        }
    }
}
