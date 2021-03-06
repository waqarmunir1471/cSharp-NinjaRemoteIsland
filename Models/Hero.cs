using System;
using System.Net.Http.Headers;

namespace cSharp_NinjaRemoteIsland.Models {
    public abstract class Hero {
        public string Name;
        public int Dexterity;
        public int Strength;
        public int Speed;
        protected int health;
        public int Health {
            get { return health; }
        }
        public void TakeDmg (int dmg) {
            health -= dmg;
        }
        public void Meditate (int dmg) {
            health += dmg;
        }
        public Hero (string name) {
            Name = name;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
        }

        public abstract void SayName ();

        public virtual void ShowStats () {
            Console.WriteLine ($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }
        public virtual int Attack (Enemy target) {
            int dmg = Strength * 3;
            target.TakeDmg (dmg);
            return target.Health;
        }
        public virtual void ChooseAttack (Enemy target) {
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine ("Please Select your Attack?\n1 : Attack.\n2 : Special Attack");
            string choice = Console.ReadLine ();
            if (choice == "1") {
                Attack (target);
            } else if (choice == "2") {
                SpecialAttack (target);
            }
            target.ShowStats();
        }
        public virtual int SpecialAttack (Enemy target) {
            int dmg = target.Health;
            target.TakeDmg (dmg);
            return target.Health;
        }

    }
}