using System.Collections.Generic;
using System.ComponentModel.Design;
using cSharp_NinjaRemoteIsland.Interfaces;
using Iron_Ninja.Models;

namespace cSharp_NinjaRemoteIsland.Models {
    public class HealthFood {
        public List<IConsumable> Menu;
        public HealthFood () {
            Menu = new List<IConsumable> () {
                new Food ("Bannana", 50),
                new Food ("Squirrel", 200),
                new Food ("Wild Boar", 1000)
            };
        }

    }
}