using System.Runtime.InteropServices;
using Game.Gold;

namespace Game
{
    // World building helper class:

    static class WorldGenerator
    {
        // Indices for the location array (see below) - NOTE: Using this location indices is optional - You can also use another, i.e. your own implemention...

        const int dungeon_entrance = 0; // Start location
        const int hall = 1;
        const int storage_room = 2;
        const int staff_room = 3;
        const int armory = 4;
        const int bedroom = 5;
        const int throne_room = 6;
        const int secret_chamber = 7; // Unreachable
        const int count = 8;


        // Build dungeon world:

        public static World BuildDungeon()
        {
            // Pre-allocate locations:

            Location[] locations = new Location[count];
            // NOTE: Using this location array is optional - You can also use another, i.e. your own implemention...

            for (int index = 0; index < count; ++index)
            {
                locations[index] = new Location();
                // Pre-allocate locations for easier world construction (see below...)
            }

            // Create new world:

            World world = new World(locations[dungeon_entrance]); // Start location      

            // Setup dungeon entry location (name and entity array):
            locations[dungeon_entrance].Name = "Entrance";
            locations[dungeon_entrance].Entities = new Entity[] {new Passage(locations[hall])};
            // TODO...
                
            // Setup hall location (name and entity array):
            locations[hall].Name = "Hall";
            locations[hall].Entities = new Entity[]
            {
                new Passage(locations[dungeon_entrance]),
                new Door(locations[storage_room]),
                new Door(locations[armory]),
                new Door(locations[throne_room], false),
                new Coin()
            };

            // TODO...

            // Setup storage room location (name and entity array):
            locations[storage_room].Name = "Storage Room";
            locations[storage_room].Entities = new Entity[]
            {
                new Door(locations[hall]),
                new Passage(locations[staff_room]),
                new Coin(),
                new Coin(),
                new Chest(50)
            };
            // TODO...

            // Setup staff room location (name and entity array):

            // TODO...
            locations[staff_room].Name = "Staff Room";
            locations[staff_room].Entities = new Entity[]
            {
                new Passage(locations[storage_room]),
                new Door(locations[hall]),
                new Door(locations[throne_room]),
                new Coin(),
                new Chest(20)
            };
            // Setup armory location (name and entity array):
            locations[armory].Name = "Armory";
            locations[armory].Entities = new Entity[]
            {
                new Passage(locations[hall]),
            };
            // TODO...

            // Setup bedroom location (name and entity array):
            locations[bedroom].Name = "Bedroom";
            locations[bedroom].Entities = new Entity[]
            {
                new Door(locations[throne_room]),
                new Coin(),
                new Chest(50)
            };
            // TODO...

            // Setup throne room location (name and entity array):
            locations[throne_room].Name = "Throne Room";
            locations[throne_room].Entities = new Entity[]
            {
                new Door(locations[bedroom]),
                new Door(locations[hall], false),
                new Door(locations[secret_chamber], false),
                new Coin(), new Coin(), new Coin(), new Coin(), new Coin(),
                new Chest(100), new Chest(100),
                new Chest(120)
            };
            // TODO...

            // Setup secret chamber (unreachable) location (name and entity array):
            locations[secret_chamber].Name = "Secret Chamber";
            locations[secret_chamber].Entities = new Entity[]
            {
                new Door(locations[throne_room], false),
                new Chest(1000)
            }; // TODO...

            return world;
        }
    }
}