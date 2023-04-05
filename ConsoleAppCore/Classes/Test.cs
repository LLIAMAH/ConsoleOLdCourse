using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore.Classes
{
    internal class Test
    {
        public void Test2()
        {

            //using ConsoleAppCore.Classes;
            //using System.Collections.Generic;

            IPlayerCharacter pc1 = new PlayerCharacter() { Name = "Egor" };
            IPlayerCharacter pc2 = new PlayerCharacter() { Name = "Squirrel" };
            IPlayerCharacter nonPc = new NonPlayerCharacter() { Name = "Zombie", Health = 200 };

            pc1.Attack(pc2);
            pc1.Attack(nonPc);
            pc2.Attack(nonPc);

            Trap.TrapWroked((ICanGetIntoTrap)pc1);
            Trap.TrapWroked((ICanGetIntoTrap)nonPc);




            var extendedArrayInt = new ExtendedArray<int>();
            var extendedArrayDouble = new ExtendedArray<double>();
            var extendedArrayRef = new ExtendedArray<PlayerCharacter>();

            extendedArrayInt.Add(6);
            extendedArrayDouble.Add(4.5);
            //extendedArrayRef.Add(pc1);
            //extendedArrayRef.Add(pc2);

            Console.WriteLine($"{pc1}");
            Console.WriteLine($"{pc2}");

            extendedArrayInt.Add(6);
            extendedArrayInt.Add(5);
            extendedArrayInt.Add(9);
            extendedArrayInt.Add(7);
            extendedArrayInt.Add(11);

            for (int i = 0; i < extendedArrayInt.Length; i++)
            {
                Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
                //extendedArrayInt[i] = 5;
            }
            // 6, 6, 5, 9, 7, 11

            extendedArrayInt = extendedArrayInt + 20;
            // 6, 6, 5, 9, 7, 11, 20
            for (int i = 0; i < extendedArrayInt.Length; i++)
            {
                Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
                //extendedArrayInt[i] = 5;
            }

            extendedArrayInt = extendedArrayInt + 45;
            // 6, 6, 5, 9, 7, 11, 20, 45 
            for (int i = 0; i < extendedArrayInt.Length; i++)
            {
                Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
                //extendedArrayInt[i] = 5;
            }


            extendedArrayInt += 21;
            // 6, 6, 5, 9, 7, 11, 20, 45, 21
            for (int i = 0; i < extendedArrayInt.Length; i++)
            {
                Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
            }

            extendedArrayInt[0] = 5;

            Console.WriteLine("Loop FOREACH");



            foreach (var item in extendedArrayInt)
            {
                Console.WriteLine($"Item: {item}");
            }

            Console.WriteLine("==============================================");

            List<int> list = new List<int>() { 34, 52, 54, 534, 453, 45, 3421, 3451, 45332, 456435, 6743, 57, 56 };
            list.AddRange(list.ToArray());


            Console.WriteLine(string.Join(",", extendedArrayInt));
            Console.WriteLine(string.Join(",", list));
        }

        public void Test1()
        {
            ValueData valueData = new ValueData();
            ClassData classData = new ClassData();

            valueData.SetNewData(4);
            classData.SetNewData(5);

            ValueData valueData1 = valueData;
            ClassData classData1 = classData;

            valueData.SetNewData(6);
            classData.SetNewData(7);

            ValueData valueData2 = valueData1;

            ClassData classData2 = new ClassData();
            ClassData classData3 = new ClassData(5);
            classData2.SetNewData(10);
            classData1 = classData2;

            var person = new Person("Vasiliy", "H", Gender.Male);

            string firstname, lastname;

            (_, lastname) = person;


            var person2 = new Person("Vasiliy", "H");

            //var item = new Item();


            try
            {
                // line 1




                /// line 1000
            }
            finally
            {

            }

            string a = "sdfassfdsdsfd";
            var length = a.Length;

            var agedPerson = new PersonAged();
            // agedPerson.a = 6;


            var personOld = new PersonOld();


            //var person1 = new Person();
            //person1.OutString(out person1.surname);
            //person1.OutString(out person1.Surname);
            //person1.OutString1(person1.Surname);

            //var string1 = "sadfasdfasdf";
            //string1.Length;


            var arrayFigures = new Figure[10];
            arrayFigures[0] = new Circle(new Point(), new Size());
            arrayFigures[1] = new Triangle(new Point(), new Size());
            arrayFigures[2] = new Square(new Point(), new Size());
            arrayFigures[3] = new Circle(new Point(), new Size());
            arrayFigures[4] = new Square(new Point(), new Size());
            arrayFigures[5] = new Triangle(new Point(), new Size());
            arrayFigures[6] = new Circle(new Point(), new Size());
            arrayFigures[7] = new Circle(new Point(), new Size());
            arrayFigures[8] = new Triangle(new Point(), new Size());
            arrayFigures[9] = new Square(new Point(), new Size());

            Figure figureSingle = new Circle(new Point(), new Size());


            for (int i = 0; i < arrayFigures.Length; i++)
            {
                arrayFigures[i].Draw();
            }


((Triangle)arrayFigures[1]).DrawUltraMegaTriangle(7);
            ((Triangle)arrayFigures[1]).DrawUltraMegaTriangle(-4);

            var staticFig1 = new Circle(new Point(), new Size());
            staticFig1.Test(5);
            Circle.data = 10;
            staticFig1.Test(5);
            var staticFig2 = new Circle(new Point(), new Size());
            staticFig1.Test(5);
            staticFig2.Test(5);
            var staticFig3 = new Circle(new Point(), new Size());
            staticFig1.Test(5);
            staticFig2.Test(5);
            staticFig3.Test(5);
            Circle.data = 7;
            staticFig1.Test(5);
            staticFig2.Test(5);
            staticFig3.Test(5);


            var strin1g = String.Format("Param1: {0}; Param2: {1}, Param3: {2}", 4, 5, 6);

        }
    }
}
