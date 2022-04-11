namespace Game
{
    // Treasure base class:
    class Treasure:Entity
    {
    }
    // TODO...
    


    // Gold treasures:

    namespace Gold
    {
        // Coin class:
        class Coin : Treasure
        {
        }
        // TODO...


        // Chest class:
        class Chest : Treasure
        {
            public uint Gold { get; set; }

            public Chest(uint gold)
            {
                Gold = gold;
            }
        }
        // TODO...
    }
}