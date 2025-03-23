
namespace WeaponNamespace
{
    class Weapon
    {
        public string Name { get; }

        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public float Durability { get; }

        public Weapon() : this("Unknown Weapon", 1, 10) { }
        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Durability = 1f;
            SetDamageParams(MinDamage, MaxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage)
        {
            if (MinDamage > MaxDamage)
            {
                int temp = minDamage;
                minDamage = maxDamage;
                maxDamage = temp;
                MinDamage = minDamage;
                MaxDamage = maxDamage;

                Console.WriteLine($"[class Weapon] Warning: {Name} maxDamage was less than minDamage");
                Console.WriteLine($"[class Weapon] {Name} = MinDamage: {MinDamage}, MaxDamage: {MaxDamage}");
            }
            else if (MinDamage < 1)
            {
                MinDamage = 1;
                Console.WriteLine($"[class Weapon] Warning: MinDamage was less than 1");
                Console.WriteLine($"[class Weapon] {Name} = MinDamage: {MinDamage}, MaxDamage: {MaxDamage}");
            }
            else if (MaxDamage <= 1)
            {
                MaxDamage = 10;
                Console.WriteLine($"[class Weapon] Warning: MaxDamage was less or equal to 1");
                Console.WriteLine($"[class Weapon] {Name} = MinDamage: {MinDamage}, MaxDamage: {MaxDamage}");
            }


        }
        public int GetDamage()
        {
            return MinDamage * MaxDamage / 2;
        }
    }
}
