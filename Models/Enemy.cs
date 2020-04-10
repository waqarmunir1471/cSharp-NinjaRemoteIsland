using System;
using System.ComponentModel.Design;

namespace cSharp_NinjaRemoteIsland.Models {
    public abstract class Enemy {
        public string Name;
        public int Dexterity;
        public int Strength;
        public int Speed;
        protected int health;
        public int Health {
            get {
                return health;
            }
        }
        public Enemy (string name) {
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
        public virtual int Attack (Hero target) 
        {
            int dmg = Strength * 3;
            target.TakeDmg (dmg);
            return target.Health;
        }
         public virtual void ChooseAttackKillHero (Hero target) {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Random rand  = new Random();
            int choice = rand.Next(0,3);
            if (choice==1) {
                Attack (target);
            } else if (choice == 2) {
                SpecialAttack (target);
            }
            target.ShowStats();
        }
        public virtual int SpecialAttack (Hero target) {
            int dmg = target.Health;
            target.TakeDmg (dmg);
            return target.Health;
        }
        public void TakeDmg (int dmg) 
        {
            health -= dmg;
        }
        
    }
}