namespace Siemensphase
{
    public class Electronic : Article
    {
        public int Power { set; get; }

        public Electronic(int power, string name, int count = default, double price = default) : base(name, count, price)
        {
            Power = power;
        }

        public override string ToString()
        {
            return base.ToString()+$",{Power}";
        }
    }
}