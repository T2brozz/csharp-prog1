using static System.Console;

namespace Game
{
  // Basic world functionality (Partial implementation -> See also: WorldPartialSolution.cs!)

  partial class World
  {
    // World construction:

    public World() { }

    public World(Location start)
    {
      Start = start;
    }

    // Start location:

    public Location Start { set; get; }

    // Simulation of one treasure hunt step:

    uint roundCount = 1u;

    public void DoTreasureHuntStep(Player player)
    {
      if (player == null || player.Location == null)
      {
        WriteLine($"{roundCount}. WARNING: Invalid player or player location!");
      }
      else
      {
        // Write player status:

        WriteLine($"{roundCount}. Player is in {(player.Location.Name != null ? player.Location.Name : "unspecified location")} and has {player.GoldCoins} gold coin(s).");

        // Try to collect gold coins at current location:

        uint collectedGoldCoins = tryToCollectGoldCoins(player);

        if (collectedGoldCoins > 0)
        {
          WriteLine($"{roundCount}. Player has picked up {collectedGoldCoins} gold coin(s) and has now {player.GoldCoins} coin(s)!");
        }

        // Try to loot gold chests at current location:

        uint lootedGoldCoins = tryToLootGoldChests(player);

        if (lootedGoldCoins > 0)
        {
          WriteLine($"{roundCount}. Player has looted gold chest(s) with {lootedGoldCoins} gold coins(s) and has now {player.GoldCoins} coin(s)!");
        }

        // Try to change location:

        Portal pickedPortal = pickRandomPortal(player);

        if (!tryToPassPortal(player, pickedPortal))
        {
          WriteLine($"{roundCount}. Player could not change the location.");
        }
      }

      // Increase round counter:

      ++roundCount;
    }
  }
}