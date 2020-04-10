// using Internal;
using System;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland {
    class Program {
        static void Main (string[] args) {
            StoryLine sLine = new StoryLine ();
            ConsoleRed ("********NINJA: REMOTE ISLAND********");
            // 
            Hero player = HeroSetup ();
            Enemy enemy = EnemySetup ();

            ConsoleRed ($"You, {player.Name}, decided to take cruise around the Pacific!  Unfortunately, there was a incident involving a wrong turn and a huge wave.  You blacked out and woke up to find yourself on a remote mysterious island.\n\nNow you must get to the beach so you can send out a distress signal and get back home.  What dangers and mysteries lurk within the jungle island?  Will you make it to the beach safely?  Is this the island with all the dinosaurs?\n\nPress Enter to Start");

            ConsoleKey key = Console.ReadKey (true).Key;
            while (key != ConsoleKey.Enter) {
                key = Console.ReadKey (true).Key;
            }
            sLine.StartGame ();
                    
            Battle batt = new Battle();
            batt.Battle1(player,enemy);
            // Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");
            //write a method that will create other team mates.

            // make a game(while) loop to run your game
        }

        static void ConsoleRed (string text) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine (text);
            Console.ResetColor ();
        }

        static Hero HeroSetup () {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine ("What is your name to be a Hero?");

            string name = Console.ReadLine ();
            string choice = "0";

            while (choice != "1" && choice != "2" && choice != "3") {
                Console.WriteLine ("Please type the number of the hero you would ike to be?\n1. Ninja\n2. Wizard\n3. Sensei");
                choice = Console.ReadLine ();
            }

            switch (choice) {
                case ("1"):
                    Ninja ninjaHero = new Ninja (name);
                    return ninjaHero;
                case ("2"):
                    Wizard wizardHero = new Wizard (name);
                    return wizardHero;
                case ("3"):
                    Sensei senseiHero = new Sensei (name);
                    return senseiHero;
            }
            return null;
        }
        static Enemy EnemySetup () {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("Please Enter Your Name to be an Enemy");
            string Ename = Console.ReadLine ();
            string Echoice = "0";
            while (Echoice != "1" && Echoice != "2" && Echoice != "3") {
                Console.WriteLine ("Please type the number of the Enemy you would ike to be?\n1. Iron Monkey\n2. Fire Monkey\n3. Bad Monkey");
                Echoice = Console.ReadLine ();
            }

            switch (Echoice) {
                case ("1"):
                    IronMonkey IronMonkey = new IronMonkey (Ename);
                    return IronMonkey;
                case ("2"):
                    FireMonkey FireMonkey = new FireMonkey (Ename);
                    return FireMonkey;
                case ("3"):
                    BadMonkey badMonkey = new BadMonkey (Ename);
                    return badMonkey;
            }
            return null;
        }
    }
}