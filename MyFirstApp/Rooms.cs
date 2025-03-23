﻿
using UnitNamespace;
using WeaponNamespace;

namespace RoomNamespace
{
    struct Room
    {
        public Unit Unit { get; }
        public Weapon Weapon { get; }

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }
}
