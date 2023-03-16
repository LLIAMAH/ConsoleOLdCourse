using System;
using System.CodeDom;
using ConsoleOLdCourse.Classes;

namespace ConsoleOLdCourse
{
    [Flags]
    public enum EnumDirection
    {
        Center = 0b00000000,
        Top = 0b00000001,
        Bottom = 0b00000010,
        Left = 0b00000100,
        Right = 0b00001000,
    }

    public enum Gender
    {
        Unknown = -1,
        Male,
        Female
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayItnSingle1 = new int[5];
                                            //0  1  2  3  4  5 - index
            var arrayItnSingle2 = new int[] { 4, 5, 6, 3, 2, 4 };
            var arrayItnSingle3 = new double[] { 4, 5, 6, 3, 2, 4 };
            var arrayItnSingle4 = new bool[] 
                { true, false, true, false, false, true };

            //                                6
            for (int i = 0; i < arrayItnSingle2.Length; i++)
            {
                if (i == 3)
                {
                    continue;
                    //break;
                }
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine($"Элемент с индексом [{i}]: " + arrayItnSingle2[i]);
            }

            int counter = 0;
            foreach (var i in arrayItnSingle2)
            {
                Console.WriteLine("Элемент: " + i);
                Console.WriteLine("Индекс: " + counter);
                counter++;
            }

            int index = 0;
            while (index < arrayItnSingle2.Length)
            {
                Console.WriteLine("Элемент first: " + arrayItnSingle2[index]);
                index++;
            }

            index = 0;
            do
            {
                Console.WriteLine("Элемент second: " + arrayItnSingle2[index]);
                index++;
            } while (index < arrayItnSingle2.Length);

            arrayItnSingle1 = new int[20];
        }

        private static void Test2()
        {
            double result;
            int a, b;
            a = 5;
            b = 2;

            result = a + b;
            Console.WriteLine($"Var1: {a}; Var2: {b}; Result: {result}");
            result = a - b;
            Console.WriteLine($"Var1: {a}; Var2: {b}; Result: {result}");
            result = a * b;
            Console.WriteLine($"Var1: {a}; Var2: {b}; Result: {result}");
            result = (double)a / b;
            Console.WriteLine($"Var1: {a}; Var2: {b}; Result: {result}");
            result = (double)a % b;
            Console.WriteLine($"Var1: {a}; Var2: {b}; Result: {result}");

            a = 5;
            result = a++;
            //result = 5;
            //a = 6;

            result = ++a;
            //result = 6;
            //a = 6;

            result = b--;
            result = --b;

            a = 5;
            a = a + 5;
            a += 5;
            a /= 5;
            a *= 5;

            a = a >> 3;
            a = a << 6;

            Int64 bigNumber = Int64.MaxValue;
            double commonNumber = (double)bigNumber;
            int int2 = (int)commonNumber;
            // Математические: + - * /
            Console.WriteLine("==================================================");

            var numberA = new BitView(a);
            var numberB = new BitView(b);

            Console.WriteLine($"\t\t{numberA.ToString()}");
            Console.WriteLine($"\t\t{numberB.ToString()}");

            // var result = numberA & numberB;
            var resultBitView = numberA.BitwiseAnd(numberB);
            Console.WriteLine($"And:\t\t{resultBitView}");

            resultBitView = numberA.BitwiseOr(numberB);
            Console.WriteLine($"Or:\t\t{resultBitView}");

            resultBitView = numberA.BitwiseXor(numberB);
            Console.WriteLine($"Xor:\t\t{resultBitView.ToString()}");

            resultBitView = numberA.BitwiseComplement();
            Console.WriteLine($"Complement:\t{resultBitView.ToString()}");

            Console.WriteLine("==================================================");

            Console.WriteLine((int)EnumDirection.Center);
            Console.WriteLine((int)EnumDirection.Top);
            Console.WriteLine((int)EnumDirection.Bottom);
            Console.WriteLine((int)EnumDirection.Left);
            Console.WriteLine((int)EnumDirection.Right);


            Console.WriteLine("==================================================");

            Console.Write("Введите значение возраста: ");
            var age = Console.ReadLine();
            var ageInt1 = Convert.ToInt32(age);
            var ageInt2 = 0;
            Int32.TryParse(age, out ageInt2);
            Console.WriteLine($"Age 1: {ageInt1}");
            Console.WriteLine($"Age 2: {ageInt2}");

            if (ageInt1 > 18)
            {
                // True
                Console.WriteLine("Можно смотреть порно!!!");
            }
            else
            {
                // False
                Console.WriteLine("Низзя смотреть порно - маленький ещё!");
            }

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
        }

        private static void Test1()
        {
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
        }
    }
}
