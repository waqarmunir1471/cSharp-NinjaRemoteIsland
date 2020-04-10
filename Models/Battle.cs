using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public class Battle {
        public void Battle1 (Hero oftheday, Enemy todefeat) {

            while (todefeat.Health >= 0) {
                oftheday.ChooseAttack (todefeat);
                todefeat.ChooseAttackKillHero (oftheday);
                if (todefeat.Health <= 0) {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine ($"{todefeat.Name} is Dead");
                }
            }
        }
    }
}