﻿using System;
using Game.Gold;

namespace Game
{
    // Implementation of player actions in the game world (Partial implementation -> See also: WorldPartial.cs!)

    partial class World
    {
        // Player tries to collect all gold coins at the location where he is at the moment:

        uint tryToCollectGoldCoins(Player player)
        {
            // Traverse entity list, searching for gold coins:

            uint collectedGoldCoins = 0u; // Number of collected gold coins at current player location...
            Entity[] list = player.Location.Entities;
            for(int i =0; i < list.Length;i++)
            {
                if (list[i] is Coin)
                {
                    collectedGoldCoins++;
                    list[i] = null;
                }
            }

            // TODO...

            return collectedGoldCoins;
        }


        // Player tries to loot all gold chests at the location where he is at the moment:

        uint tryToLootGoldChests(Player player)
        {
            // Traverse entity list, searching for gold chests:

            uint
                lootedGoldCoins =
                    0u; // Number of looted gold coins (from treasure chests) at current player location...

            // TODO...

            return lootedGoldCoins;
        }


        // Player picks a random portal at the location where he is at the moment:

        Random
            random = new Random(Guid.NewGuid()
                .GetHashCode()); // NOTE: Use this random generator (initialized with a unique random seed)!

        Portal pickRandomPortal(Player player)
        {
            // Count portals in current location:

            // TODO...

            // Pick n-th portal from entity array:

            // TODO...

            return null;
        }


        // Player tries to pass the portal at the location he is currently at:

        bool tryToPassPortal(Player player, Portal portal)
        {
            // Check if portal is valid and, if it is a door, then if is not locked:

            // TODO...

            // Change player location:

            // TODO...

            return true; // Successful portal pass...
        }
    }
}