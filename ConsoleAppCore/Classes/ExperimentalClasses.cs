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
        private readonly string name;
        private string surname;
        private Gender gender;
        private int a;

        public Person() : this("", ""){}

        public Person(string name, string surname) : this(name, surname, Gender.Unknown)
        {

        }

        public Person(string name, string surname, Gender gender)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
        }

        public void Test()
        {
            //this.name = "sdafgsdfgsdfg;sdfl";
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
            //this.name = "sdafgsdfgsdfg;sdfl";
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
}
