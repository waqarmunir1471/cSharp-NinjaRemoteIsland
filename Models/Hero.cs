using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public abstract class Hero
    {
        public string Name;
        public int Dexterity;
        public int Strength;
        public int Speed;
        protected int health;

        public Hero(string name)
        {
            Name = name;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
        }

        public abstract void SayName();

        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }



    }
}