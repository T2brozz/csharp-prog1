namespace Game
{
  // Player (in game world):

  class Player
  {
    // Player construction:

    public Player() { }

    public Player(Location location) { Location = location; }

    // Current location:

    public Location Location { set; get; }

    // Collected gold coins:

    public uint GoldCoins { set; get; }
  }
}
