using System;
using ConsoleOLdCourse.Classes;
using OurPersonalLib.Structures;

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

    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static T[] IncrementArraySize<T>(T[] array)
        {
            var length = array.Length;
            var tempArray = new T[length + 1];
            for (int i = 0; i < length; i++)
            {
                tempArray[i] = array[i];
            }

            return tempArray;
        }

        static int SumThreeNumber(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        static int SumThreeNumber(int a = 0, int b = 0)
        {
            return a + b;
        }

        static T[] IncrementArraySize<T>(T[] array, T inputValue)
        {
            var length = array.Length;
            var tempArray = new T[length + 1];
            for (int i = 0; i < length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[length] = inputValue;

            return tempArray;
        }

        static string Conversion<T>(T inputValue)
        {
            return inputValue.ToString();
        }

        //static int[] IncrementArraySize(int[] array, bool totalyNew = false)
        //{
        //    if (totalyNew)
        //    {
        //        return new int[array.Length + 1];
        //    }

        //    var length = array.Length;
        //    var tempArray = new int[length + 1];
        //    for (int i = 0; i < length; i++)
        //    {
        //        tempArray[i] = array[i];
        //    }

        //    return tempArray;
        //}

        //static double[] IncrementArraySize(double[] array)
        //{
        //    var length = array.Length;
        //    var tempArray = new double[length + 1];
        //    for (int i = 0; i < length; i++)
        //    {
        //        tempArray[i] = array[i];
        //    }

        //    return tempArray;
        //}

        private static double Sum(double a, double b)
        {
            a = a * 10;
            b = b * 5;
            return a + b;
        }

        private static double Sum1(ref double a, ref double b)
        {
            a = a * 10;
            b = b * 5;
            return a + b;
        }

        private static double Sum2(in double a, in double b)
        {
            return a + b;
        }

        private static double Sum3(double a, double b, out bool aLessB)
        {
            if (a < b)
                aLessB = true;
            else
                aLessB = false;

            return a + b;
        }

        private static void DrawArray(int[,] array, int intX, int intY)
        {
            for (int j = 0; j < intY; j++)
            {
                for (int i = 0; i < intX; i++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        private static double ConvertStringToDouble(string aString)
        {
            int res1;
            double res2;
            try
            {
                res1 = Convert.ToInt32(aString);
                return res1;
            }
            catch
            {
                try
                {
                    res2 = Convert.ToDouble(aString);
                    return res2;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return 0;
        }

        private static void Test7()
        {
            try
            {
                var t = Console.ReadLine();

                var person1 = new Person("Жук");
                var person2 = new Person("Муха");

                Person person3 = new Person() { Name = "Павук!", Health = 120 };

                do
                {
                    person1.Attack(ref person2);
                    person2.Attack(ref person1);
                } while (person1.IsNotDead() || person2.IsNotDead());

                if (person1.IsNotDead())
                {
                    Console.WriteLine($"Победил {person1.Name}");
                }
                else if (person2.IsNotDead())
                {
                    Console.WriteLine($"Победил {person2.Name}");
                }
                else
                {
                    Console.WriteLine("Погибли оба");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                var t = Console.ReadLine();
            }
        }

        private static void Test6()
        {
            int a1, a2, a3;
            a1 = 10;
            a2 = 20;
            a3 = 30;

            var resultSum3 = SumThreeNumber(a1, a2, a3);

            var rand = new Random();
            var array = new int[10];
            var arrayDouble = new double[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(30) + 1;
            }

            Console.WriteLine(string.Join(", ", array));

            array = IncrementArraySize(array);
            arrayDouble = IncrementArraySize<double>(arrayDouble);
            Console.WriteLine(string.Join(", ", array));

            array = IncrementArraySize(array);
            Console.WriteLine(string.Join(", ", array));
        }

        private static void Test5()
        {
            Console.Write("Введите первое число: ");
            var aString = Console.ReadLine();
            var a = ConvertStringToDouble(aString);

            Console.Write("Введите второе число: ");
            var bString = Console.ReadLine();
            var b = ConvertStringToDouble(bString);

            // a =3 b = 2
            var result = Sum(a, b);
            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");

            var result2 = Sum1(ref a, ref b);
            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");
            Console.WriteLine($"Результатом сложения будет: {result}");
            Console.WriteLine($"Результатом сложения будет: {result2}");

            var result3 = Sum3(a, b, out bool aLessB);
            if (aLessB)
                Console.WriteLine("A меньше B");
            else
                Console.WriteLine("A больше B");

            Console.WriteLine($"Результатом сложения будет: {result3}");
        }

        private static void Test4()
        {
            //var arraySingle = new double[35]; // {}

            var rand1 = new Random(5);
            var rand2 = new Random(5);

            var random1 = rand1.Next();
            Console.WriteLine($"Охрененно большое псевдослучайное число: {random1}");
            var random2 = rand1.Next(50) + 1;
            Console.WriteLine($"Псевдослучайное число [1-50]: {random2}");
            var random3 = rand1.Next(1, 30);
            Console.WriteLine($"Псевдослучайное число [1<30]: {random3}");

            var random21 = rand2.Next();
            Console.WriteLine($"Охрененно большое псевдослучайное число: {random21}");
            var random22 = rand2.Next(50) + 1;
            Console.WriteLine($"Псевдослучайное число [1-50]: {random22}");
            var random23 = rand2.Next(1, 30);
            Console.WriteLine($"Псевдослучайное число [1<30]: {random23}");

            Console.WriteLine("Работа с массивами");

            try
            {
                var arrayX = new int[5, 4];

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        arrayX[i, j] = rand1.Next(10) + 5;
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"{arrayX[i, j]} ");
                    }

                    Console.WriteLine();
                }

                arrayX[6, 6] = rand1.Next(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Console.WriteLine("Работа с зубчатыми массивами");


            try
            {
                // 1, 2, 3, 4
                // 1, 2
                // 1, 2, 3, 4, 5, 6, 7, 8, 9
                int[][] arrayJagged = new int[5][];
                arrayJagged[0] = new int[5];
                arrayJagged[1] = new int[3];
                arrayJagged[2] = new int[6];
                arrayJagged[3] = new int[11];
                arrayJagged[4] = new int[2];

                for (int i = 0; i < 5; i++)
                {
                    for (var j = 0; j < arrayJagged[i].Length; j++)
                    {
                        var tep = 5;
                        arrayJagged[i][j] = rand1.Next(20) + 5;
                    }
                }



                for (int i = 0; i < 5; i++)
                {
                    for (var j = 0; j < arrayJagged[i].Length; j++)
                    {
                        Console.Write($"{arrayJagged[i][j]} ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < 6; i++)
                    arrayJagged[2][i] = rand1.Next(20);

                Console.WriteLine("==============================");

                var array = new int[5];
                var array1 = new int[] { 5, 6, 76, 5, 4, 3 };
                var tempArray = arrayJagged[2];
                arrayJagged[2] = new int[7];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    arrayJagged[2][i] = tempArray[i];
                }

                arrayJagged[2][6] = 1;


                for (int i = 0; i < 5; i++)
                {
                    for (var j = 0; j < arrayJagged[i].Length; j++)
                        Console.Write($"{arrayJagged[i][j]} ");

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //try
            //{
            //    throw new Exception("Какая то хрень, чувак, завязывай с программированием - ты лошара!");

            //    //var b = 0;
            //    //int a = 10 / b;

            //    // arrayX[5, 5] = 0; // Invalid boundries

            //    //arrayX[0, 0] = 0; // All good
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Что-то пошло не так: {e.Message}");
            //}


            //for (int j = 0; j < 4; j++)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.Write($"{arrayX[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
        }

        private static void Test3()
        {
            var stroka = "asdfasdfa\\sdfas\ndfgdksfgjsd;flgkdjsfg;lskdfjg;sdflkgsdfg";
            //var simbol = '';
            for (int i = 0; i < stroka.Length; i++)
            {
                var a = stroka[i];
            }

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
