
namespace classes
{
    // Дз по Классам
    public class Unit
    {
        public string Name { get; }
        private float _health;

        public float Health => _health;
        public int Damage { get; }
        public float Armor;

        public Unit() : this("Unknown Unit", 5, 0.6f) { }

        public Unit(string name, int damage, float armor)
        {
            Name = name;
            Damage = damage;
            Armor = armor;
            _health = 5f;
        }

        public float GetRealHealth()
        {
            return _health * (1 + Armor);
        }
        public bool SetDamage(float value)
        {
            _health -= value * Armor;
            return _health <= 0f;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Unit New_unit = new Unit();
                Console.WriteLine(New_unit.Name);
                Console.WriteLine(New_unit.Damage);
                Console.WriteLine(New_unit.Armor);
                Console.WriteLine(New_unit.GetRealHealth());
                Console.WriteLine(New_unit.SetDamage(0));
            }
        }
    }
}
