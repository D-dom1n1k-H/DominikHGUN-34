
using RoomNamespace;
using UnitNamespace;
using WeaponNamespace;

namespace DungeonNamespace
{
    class Dungeon
    {
        private Room[] rooms;

        public Dungeon()
        {
            Random rnd = new Random();
            int roomCount = rnd.Next(3, 6);
            rooms = new Room[roomCount];
        }

        public void ShowRooms()
        {
            Random rand = new Random();
            string[] UnitNames = { "Unknown Unit", "Warrior", "Fighter", "Soldier", "Barbarian" };
            string[] WeaponNames = { "Sword", "Bow", "Gun", "Hand" };


            for (int i = 1; i < rooms.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"Room {i}:");
                Console.WriteLine("");
                Unit unit1 = new Unit(UnitNames[rand.Next(UnitNames.Length)]);
                Weapon weapon1 = new Weapon(WeaponNames[rand.Next(WeaponNames.Length)], 5, 12);
                rooms[0] = new Room(unit1, weapon1);

                Console.WriteLine($"Unit in room: {rooms[0].Unit.Name}");
                Console.WriteLine($"Unit information:");
                Console.WriteLine("");
                Console.WriteLine($"GetRealHealth = {unit1.GetRealHealth()}");
                Console.WriteLine($"SetDamage = {unit1.SetDamage(0)}");
                Console.WriteLine("");

                Console.WriteLine($"Weapon in room: {rooms[0].Weapon.Name}");
                Console.WriteLine($"Weapon information:");
                Console.WriteLine("");
                Console.WriteLine($"MinDamage = {weapon1.MinDamage}");
                Console.WriteLine($"MaxDamage = {weapon1.MaxDamage}");
                Console.WriteLine($"GetDamage = {weapon1.GetDamage()}");

            }
        }
    }
}
