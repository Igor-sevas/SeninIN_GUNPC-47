
namespace Classes
{
    internal class Weapon
    {
        public string Name { get; }
        public float Durability { get; }

        public Interval Damage { get; }
        public Weapon(string name) : this(name, 1, 10) { }
        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            Durability = 1f;
            Damage = new Interval(minDamage, maxDamage);
        }
        public int GetDamage() => (int)Damage.Get();




    }
}