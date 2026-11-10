namespace Classes
{
    internal class Unit
    {
        private float _health;

        public string Name { get; }
        public float Health => _health;
        public int Damage { get; }
        public float Armor { get; }

        public Unit() : this("Unknown Unit")
        {
        }

        public Unit(string name)
        {
            Name = name;
            _health = 100f;
            Damage = 5;
            Armor = 0.6f;
        }

        public float GetRealHealth()
        {
            return _health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            _health -= value * Armor;
            return _health <= 0f;
            if (_health <= 0f)
            {
                _health = 0f;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}