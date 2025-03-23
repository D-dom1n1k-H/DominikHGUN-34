
namespace UnitNamespace
{
    public class Unit
    {
        public string Name { get; }
        private float _health = 5f;

        public float Health => _health;
        public int Damage { get; }
        public float Armor { get; }

        public Unit() : this("Unknown Unit") { }

        public Unit(string name)
        {
            Name = name;
            Damage = 5;
            Armor = 0.6f;
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

    }
}



namespace MyFirstApp
{
    class Unit
    {
    }
}
