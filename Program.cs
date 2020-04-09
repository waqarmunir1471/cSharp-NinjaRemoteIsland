using System;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleRed("********NINJA: REMOTE ISLAND********");

            Hero player = PlayerSetup();
            
            ConsoleRed($"You, {player.Name}, decided to take cruise around the Pacific!  Unfortunately, there was a incident involving a wrong turn and a huge wave.  You blacked out and woke up to find yourself on a remote mysterious island.\n\nNow you must get to the beach so you can send out a distress signal and get back home.  What dangers and mysteries lurk within the jungle island?  Will you make it to the beach safely?  Is this the island with all the dinosaurs?\n\nPress Enter to Start");

            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");

            //write a method that will create other team mates.

            // make a game(while) loop to run your game
        }

        static void ConsoleRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Hero PlayerSetup()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please type the number of the hero you would ike to be?\n1. Ninja\n2. Wizard\n3. Sensei");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Ninja ninjaHero = new Ninja(name);
                    return ninjaHero;
                case("2"):
                    // Change Ninja to another class of hero.
                    Ninja wizardHero = new Ninja(name);
                    return wizardHero;
                case("3"):
                    // Change Ninja to another class of hero.
                    Ninja senseiHero = new Ninja(name);
                    return senseiHero;
            }
            return null;
        }
    }
}
