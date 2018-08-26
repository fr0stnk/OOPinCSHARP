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
        private int Health;

        public virtual void TakeDamage(int damage)
        {
            
        }

        private void CheckState()
        {
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }
    }

    class Wombat
    {
        public int Health;
        public int Armor;

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }
    }

    class Human
    {
        public int Health;
        public int Agility;

        public void TakeDamage(int damage)
        {
            Health -= damage / Agility;
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }
    }
}
