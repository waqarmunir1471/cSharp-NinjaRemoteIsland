using System;


namespace cSharp_NinjaRemoteIsland.Models
{
    public class FireMonkey : Enemy {

        public FireMonkey (string name) : base (name) {
            Name = name;
            Dexterity = 2;
            Strength = 7;
            Speed = 15;
            health = 125;
        }
        public override void SayName () {
            Console.WriteLine ($"My name is {Name}! I am a fierce IronMonkey!");
        }
        public override void ShowStats () {
            Console.WriteLine ($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }
        public override int Attack (Hero target) 
        {
            int dmg = Speed * 2;
            target.TakeDmg (dmg);
            Console.WriteLine("Spitting Fire!");
            return target.Health;
        }

    }
}