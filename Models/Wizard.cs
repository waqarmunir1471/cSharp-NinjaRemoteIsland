using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Wizard : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Wizard(string name) : base(name){}
        public override int Attack(Enemy target){
            int dmg = target.Strength*3;
            target.TakeDmg(dmg);
            Console.WriteLine("Doing magic to kill Enemy!!!");
            return target.Health;
        }
    }
}