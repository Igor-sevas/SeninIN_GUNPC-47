using static System.Console;

namespace Classes
{
    internal class Dungeon
    {
        private readonly Room[] _rooms;

        public Dungeon()
        {
            _rooms = new Room[]
            {
                new Room(new Unit("Goblin"), new Weapon("Dagger", 1, 3)),
                new Room(new Unit("Orc"),     new Weapon("Axe", 2, 6)),
                new Room(new Unit("Knight"), new Weapon("Sword", 3, 7)),
                new Room(new Unit("Mage"),   new Weapon("Staff", 1, 9))
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                var room = _rooms[i];
                WriteLine("Unit of room " + room.Unit.Name);
                WriteLine("Weapon of room " + room.Weapon.Name);
                WriteLine($"Unit damage: {room.Unit.Damage.Min}-{room.Unit.Damage.Max}");
                WriteLine($"Weapon damage: {room.Weapon.Damage.Min}-{room.Weapon.Damage.Max}");
            }
        }
    }
}