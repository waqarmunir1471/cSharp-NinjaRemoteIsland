using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Sensei : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Sensei(string name) : base(name){}

        public override int Attack(Enemy target){
            int dmg = target.Strength*5;
            target.TakeDmg(dmg);
            Console.WriteLine("Right Away Killed!!!");
            return target.Health;
        }
    }
}