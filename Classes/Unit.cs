namespace Classes
{
    internal class Unit
    {
        private float _health;

        public string Name { get; }
        public float Health => _health;
        public float Armor { get; }

        public Interval Damage { get; }

        public Unit() : this("Unknown Unit", 0, 15) { }

        public Unit(string name) : this(name, 0, 15) { }

        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            _health = 100f;
            Damage = new Interval(minDamage, maxDamage);
            Armor = 0.6f;
        }

        public float GetRealHealth()
        {
            return _health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            _health -= value * Armor;

            if (_health <= 0f)
            {
                _health = 0f;
                return true;
            }

            return false;
        }
    }
}