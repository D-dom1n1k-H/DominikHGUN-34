
using System.Dynamic;
using IntervalNamespace;

namespace WeaponNamespace
{
    class Weapon
    {
        public string Name { get; }

        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public float Durability { get; }

        Interval Weapon_interval = new Interval(1, 10);
        public Weapon() : this("Unknown Weapon") { }
        public Weapon(string name)
        {
            Name = name;
            MinDamage = Weapon_interval.Min;
            MaxDamage = Weapon_interval.Max;
            Durability = 1f;
        }


        public int GetDamage()
        {
            return MinDamage * MaxDamage / 2;
        }
    }
}
