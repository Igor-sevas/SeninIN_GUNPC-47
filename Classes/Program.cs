using static System.Console;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter weapon name:");
            string name = ReadLine();
          
            while (string.IsNullOrWhiteSpace(name))
            {
                WriteLine("Weapon name cannot be empty. Please enter a valid name:");
                name = ReadLine();
            }

            name = string.Join(" ", name.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        
            Weapon weapon = new Weapon(name);

            WriteLine($"Weapon: \"{weapon.Name}\", Damage:  {(int) weapon.GetDamage()}, Durability: {weapon.Durability}");


            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();

            WriteLine("Пример работы Interval:");
            var interval = new Interval(10, 3); 
            WriteLine($"Min: {interval.Min}, Max: {interval.Max}");
            WriteLine($"Random: {interval.Get()}");
        }
    }
}