using cSharp_NinjaRemoteIsland.Interfaces;

namespace Iron_Ninja.Models {
    class Food : IConsumable {
        public string Name { get; set; }
        public int HealthPoints { get; set; }   
        public string GetInfo () {
            return $"{Name} (Food).\nCalories: {HealthPoints}.";
        }
        public Food (string name, int hp) 
        {
            Name = name;
            HealthPoints = hp;
        }
    }

}