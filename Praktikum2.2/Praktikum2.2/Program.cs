using System;
using static System.Console;

class Program
{
    // Treasure hunt goal:

    const uint goldCoinsGoal = 450u;

    // Game application:

    static void Main()
    {
        // Build new dungeon game world:  

        Game.World world = Game.WorldGenerator.BuildDungeon();


        // Create new player:

        Game.Player player = new Game.Player(world.Start); // Player at start location


        // Simulate (endless) treasure hunt (until "Escape" is pressed):

        bool treasureHuntGoalReached = false;

        WriteLine("PRESS \"ESCAPE\" TO STOP TREASURE HUNT...");

        ConsoleKey consoleKey;

        do
        {
            // Simulate treasure hunt as long as no key is pressed:

            while (!KeyAvailable)
            {
                world.DoTreasureHuntStep(player);
                // Check for treasure hunt goal:

                if (!treasureHuntGoalReached && player.GoldCoins >= goldCoinsGoal)
                {
                    treasureHuntGoalReached = true;

                    WriteLine(
                        $"TREASURE HUNT GOAL OF {goldCoinsGoal} GOLD COINS REACHED! (Press a key to continue hunt...)");

                    for (uint beeps = 0; beeps < 3; ++beeps)
                    {
                        Beep();
                    }

                    ReadKey(true); // Pause...
                }
            }

            // Read key from console buffer and pause, if "Escape" was not pressed:

            consoleKey = ReadKey(true).Key;

            if (consoleKey != ConsoleKey.Escape)
            {
                ReadKey(true); // Pause...
            }
        } while (consoleKey != ConsoleKey.Escape);
    }
}