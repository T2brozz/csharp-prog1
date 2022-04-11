namespace Game
{
    // Portal base class:

    class Portal : Entity // TODO...
    {
        public Location Target { get; set; }

        public Portal(Location target)
        {
            Target = target;
        }
    }


    // Passage class:
    class Passage : Portal
    {
        public Passage(Location target) : base(target)
        {
        }
    }
    // TODO...


    // Door class:
    class Door : Portal
    {
        private bool Unlocked { get; set; } = true;

        public Door(Location target, bool unlocked = true) : base(target)
        {
            Unlocked = unlocked;
        }
    }
    // TODO...
}