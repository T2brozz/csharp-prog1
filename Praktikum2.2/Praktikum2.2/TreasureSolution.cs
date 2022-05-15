namespace Game
{
    // Treasure base class:
    class Treasure:Entity
    {
    }
    


    // Gold treasures:

    namespace Gold
    {
        // Coin class:
        class Coin : Treasure
        {
        }


        // Chest class:
        class Chest : Treasure
        {
            public uint Gold { get; set; }

            public Chest(uint gold)
            {
                Gold = gold;
            }
        }
    }
}