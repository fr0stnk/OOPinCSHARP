using System;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class Creature
    {
        protected int Health;

        public virtual void TakeDamage(int damage)
        {
            
        }

        protected void CheckState()
        {
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }
    }

    class Wombat : Creature
    {
        public int Armor;

        public override void TakeDamage(int damage)
        {
            Health -= damage - Armor;
            CheckState();
        }
    }

    class Human : Creature
    {
        public int Agility;

        public override void TakeDamage(int damage)
        {
            Health -= damage / Agility;
            CheckState();
        }
    }
}
