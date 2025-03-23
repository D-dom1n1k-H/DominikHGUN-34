using DungeonNamespace;
using IntervalNamespace;
using RoomNamespace;
using UnitNamespace;
using WeaponNamespace;

namespace Program
{
    // Дз по Классам и не только

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Class Weapon:");
            Console.WriteLine("");
            Weapon New_weapon = new Weapon();

            Console.WriteLine($"Name = {New_weapon.Name}");
            Console.WriteLine($"MinDamage = {New_weapon.MinDamage}");
            Console.WriteLine($"MaxDamage = {New_weapon.MaxDamage}");
            Console.WriteLine($"Durability = {New_weapon.Durability}");
            Console.WriteLine($"GetDamage = {New_weapon.GetDamage()}");
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Class Unit:");
            Console.WriteLine("");
            Unit New_unit = new Unit();

            Console.WriteLine($"Name = {New_unit.Name}");
            Console.WriteLine($"Damage = {New_unit.Damage}");
            Console.WriteLine($"Armor = {New_unit.Armor}");
            Console.WriteLine($"GetRealHealth = {New_unit.GetRealHealth()}");
            Console.WriteLine($"SetDamage = {New_unit.SetDamage(0)}");
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Struct Interval:");
            Console.WriteLine("");
            Interval new_interval = new Interval(10, 5);

            Console.WriteLine($"Min = {new_interval.Min}");
            Console.WriteLine($"Max = {new_interval.Max}");
            Console.WriteLine($"Get = {new_interval.Get}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Struct Room:");
            Console.WriteLine("");

            Unit warrior = new Unit("Warrior");
            Weapon sword = new Weapon("Sword", 10, 20);
            Room battleRoom = new Room(warrior, sword);

            Console.WriteLine($"Unit in room: {battleRoom.Unit.Name}");
            Console.WriteLine($"Weapon in room: {battleRoom.Weapon.Name}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Class Dungeon:");
            Console.WriteLine("");

            Dungeon new_dungeon = new Dungeon();
            new_dungeon.ShowRooms();

        }
    }
}



