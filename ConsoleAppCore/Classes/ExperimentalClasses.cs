using System.Drawing;
using System.Runtime.CompilerServices;

namespace ConsoleAppCore.Classes
{
    public struct ValueData
    {
        private int _data;

        public ValueData()
        {
            this._data = 0;
        }

        public void SetNewData(int data)
        {
            this._data = data;
        }
    }

    public class ClassData
    {
        private int _data;
        private int data;

        public ClassData():this(0,0)
        { }

        public ClassData(int data)
        {
            this.data = data;
        }

        public ClassData(int data, int data1)
        {
            this.data = data;
            this._data = data1;
        }

        public void SetNewData(int data)
        {
            this._data = data;
        }

        public ClassData Copy()
        {
            var classReturn = new ClassData();
            classReturn._data = this._data;
            return classReturn;
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    // 1. Наследование
    // 2. Инкапсуляция
    // 3. Полиморфизм.

    public class Person
    {
        protected readonly string name;
        protected string surname;
        protected Gender gender;
        public int age;

        public string Surname { get; set; }

        public string Surname1 { get; init; }

        protected string Name
        {
            get
            {
                Surname = "safasdfasdfasdf";
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                    throw new Exception("Вы слишкорм юны для посещения сайта");

                age = value;
                //OnUpdate();
            }
        }

        public void OutString()
        {
            this.Surname = "sdfasdfasdf";
            var a = this.Surname;
        }

        public void OutString1(string output)
        {
            this.Surname = "sdadfasdfasdf";
            ;
            output = "sdadfasdfasdf";
        }


        public Person() : this("", ""){}

        public Person(string name, string surname) : this(name, surname, Gender.Unknown)
        {
            this.Surname1 = "sdfasdfasdfaswdf";
        }

        public Person(string name, string surname, Gender gender)
        {
            this.Surname1 = "sdfasdfasdfaswdf";
            this.name = name;
            this.gender = gender;
        }

        public void Test()
        {
            this.Age = 40;
        }

        public void Deconstruct(out string name, out string surname)
        {
            name = this.name;
            surname = this.surname;
        }
    }

    public class PersonOld : Person
    {
        public void Test()
        {
        }
    }

    public class PersonAged : PersonOld
    {
        public void Test()
        {


        }

        // public / protected / private
        // internal / private protected /protected internal / file

    }


    public enum FigureType
    {

    }

    public abstract class Figure
    {
        protected readonly Point _point;
        protected readonly Size _size;

        public Figure(Point point, Size size)
        {
            _point = point;
            _size = size;
        }

        public abstract void Draw();
    }

    public sealed class Triangle : Figure
    {
        public Triangle(Point point, Size size) : base(point, size) { }

        public override void Draw()
        {
            Console.WriteLine("Мы нарисовали треугольник!");
        }

        /*
        public static void DrawUltraMegaTriangle(this Triangle triangle)
        {
            Console.WriteLine("Мы нарисовали супер мега ультра треугольник!");
        }
         */
    }

    public static class TriangleExtension
    {
        public static void DrawUltraMegaTriangle(this Triangle triangle, int a = 5)
        {
            if(a > 0)
                Console.WriteLine("Мы нарисовали супер мега ультра треугольник!");
            else 
                triangle.Draw();
        }

        public static void DrawUltraMegaSquare(this Square triangle)
        {
            Console.WriteLine("Мы нарисовали супер мега ультра квадрат!");
        }
    }


    public class Square : Figure
    {
        public Square(Point point, Size size) : base(point, size) { }

        public override void Draw()
        {
            Console.WriteLine("Мы нарисовали квадрат!");
        }
    }

    public class Circle : Figure
    {
        public static int data = 5;

        public Circle(Point point, Size size) : base(point, size) { }

        public override void Draw()
        {
            Console.WriteLine("Мы нарисовали круг!");
        }

        public void Test(int someParameter)
        {
            Console.WriteLine($"Some parameter: {someParameter}");
            Console.WriteLine($"Data: {data}");
            TestData();
        }

        public static void TestData()
        {
            
        }

    }
}
