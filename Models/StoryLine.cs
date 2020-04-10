using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public class StoryLine {
        public void StartGame () 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("You wake up on the beach of a deserted island. There is nothing around you but monkies. They look like bad monkies.");
            Console.ResetColor ();
        }
    }
}