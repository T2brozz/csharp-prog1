namespace Game
{
  // Game "entity" base class (= any object at a game location):

  class Entity { }

  // Location (in game world):

  class Location
  {
    // Location construction:

    public Location() { }

    public Location(string name, Entity[] entities)
    {
      Name = name;

      Entities = entities;
    }

    // Text description of location:

    public string Name { set; get; }

    // Array of game entities (e. g. gold coins, doors etc.), located at current location:

    public Entity[] Entities { set; get; }
  }
}