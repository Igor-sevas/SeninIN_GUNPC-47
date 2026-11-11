
namespace Classes
{
    internal class Weapon
    {
        public string Name { get; }
        public float Durability { get; }
        
        private readonly Interval _damageInterval;
        public Weapon(string name) : this(name, 1, 10) { }
        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            Durability = 1f;
            _damageInterval = new Interval(minDamage, maxDamage);
        }
        public int GetDamage() => (int)_damageInterval.Get();




    }
}