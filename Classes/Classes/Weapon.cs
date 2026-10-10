using System;
using static System.Console;
namespace Classes
{
    internal class Weapon
    {
        public string Name { get; }
        public int minDamage { get; private set; }
        public int maxDamage { get; private set; }
        public float Durability { get; }
        public Weapon(string name)
        {
            this.Name = name;
            this.Durability = 1f;
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {

            SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                WriteLine($"Некорректные входные данные для оружия \"{Name}\". Меняем местами значения минимального урона и максимального урона.");

                int temp = minDamage;
                minDamage = maxDamage;
                maxDamage = temp;

            }

            if (minDamage < 1)
            {
                WriteLine($"Форсированная установка минимального значения урона (1) для оружия \"{Name}\".");
                minDamage = 1;
            }

            if (maxDamage <= 1)
            {
                WriteLine($"Форсированная установка максимального значения урона (10) для оружия \"{Name}\".");
                maxDamage = 10;
            }
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }


        public int GetDamage() => (this.minDamage + this.maxDamage) / 2;

    }
}