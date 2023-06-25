using System;
using System.Runtime.InteropServices;

namespace OurPersonalLib.Structures
{
    public enum Gender
    {
        Unknown = -1,
        Male,
        Female
    }

    public struct Person
    {
        public string Name;
        public int Health;
        private Random _random;

        public Person(string name)
        {
            Name = name;
            Health = 100;
            _random = new Random();
        }

        public void Attack(ref Person enemy)
        {
            var hit = _random.Next(10);
            enemy.Health = enemy.Health - hit;
            if (enemy.Health <= 0)
            {
                Console.WriteLine($"{Name} погиб.");
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Health})";
        }

        public bool IsNotDead()
        {
            return Health > 0;
        }
    }
}