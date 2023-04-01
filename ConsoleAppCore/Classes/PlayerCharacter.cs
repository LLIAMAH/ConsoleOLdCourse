using System;

namespace ConsoleAppCore.Classes
{
    public interface IPlayerCharacter
    {
        public string Name { get; }
        public int Health { get; }
        public void Atack(IPlayerCharacter character);
        void DecreaseHealth(int hitCount);
    }

    public interface ICanGetIntoTrap
    {
        void DecreaseHealth(int hitCount);
    }

    public class PlayerCharacter : IPlayerCharacter, ICanGetIntoTrap
    {
        public string Name { get; init; }
        public int Health { get; private set; }

        public PlayerCharacter()
        {
            this.Health = 100;
        }

        public void Atack(IPlayerCharacter enemy)
        {
            var d20Result = Dice.Roll2(DiceFacet.D20); 
            if (d20Result > 5)
            {
                var d6Result = Dice.Roll2(DiceFacet.D6);
                Hit(enemy, d6Result);
            }
        }

        private void Hit(IPlayerCharacter enemy, int hitCount)
        {
            enemy.DecreaseHealth(hitCount);
        }

        public void DecreaseHealth(int hitCount)
        {
            this.Health -= hitCount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, health: {Health}";
        }
    }

    public class NonPlayerCharacter : IPlayerCharacter, ICanGetIntoTrap
    {
        public string Name { get; init; }
        public int Health { get; set; }
        public void Atack(IPlayerCharacter character)
        {
            var d20Result = Dice.Roll2(DiceFacet.D20);
            if (d20Result > 5)
            {
                var d6Result = Dice.Roll2(DiceFacet.D6);
                Hit(character, d6Result);
            }
        }

        private void Hit(IPlayerCharacter enemy, int hitCount)
        {
            enemy.DecreaseHealth(hitCount);
        }

        public void DecreaseHealth(int hitCount)
        {
            this.Health -= hitCount;
        }
    }

    public static class Trap
    {
        public static void TrapWroked(ICanGetIntoTrap character)
        {
            var decrease = Dice.Roll(DiceFacet.D8);
            character.DecreaseHealth(decrease);
        }
    }
}
