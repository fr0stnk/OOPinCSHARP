using System;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // Агрегация
    class Vector2
    {
        public int X, Y;
    }

    // Композиция
    class Health
    {
        public float Value;

        public bool IsAlive
        {
            get
            {
                return Value > 0;
            }
        }

        public void ApplyDamage(float damage)
        {
            Value -= damage;
        }
    }

    // Агрегация
    class Map
    {
        public char[,] Cells;

        public char GetCell(int x, int y)
        {
            return Cells[x, y];
        }

        public int Width
        {
            get
            {
                return Cells.GetLength(0);
            }
        }

        public int Height
        {
            get
            {
                return Cells.GetLength(1);
            }
        }
    }

    class Player
    {
        public Health Health;
        public Map Map;
        public Vector2 Position;

        public Player(Map map, Vector2 vector2)
        {
            Health = new Health();
            Map = map;
            Position = vector2;
        }

        public void Update()
        {
            if (Position.X < Map.Width)
            {
                Position.X++;
                if (Map.GetCell(Position.X, Position.Y) == '#')
                {
                    Health.ApplyDamage(10);
                }
            }
        }
    }
}
