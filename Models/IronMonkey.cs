using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public class IronMonkey : Enemy {

        public IronMonkey (string name) : base (name) {
            Name = name;
            Dexterity = 1;
            Strength = 12;
            Speed = 1;
            health = 150;
        }
        public override void SayName () {
            Console.WriteLine ($"My name is {Name}! I am a fierce IronMonkey!");
        }
        public override void ShowStats () {
            Console.WriteLine ($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }
        public override int Attack (Hero target) 
        {
            int dmg = Strength * 3;
            target.TakeDmg (dmg);
            Console.WriteLine("Hitting with Iron Fist!");
            return target.Health;
        }

    }
}