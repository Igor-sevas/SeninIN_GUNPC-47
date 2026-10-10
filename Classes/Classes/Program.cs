using static System.Console;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter weapon name:");
            string name = ReadLine();
            //if (string.IsNullOrWhiteSpace(name))
            //{
            //    WriteLine("Weapon name cannot be empty. Using default name 'Default Weapon'.");
            //    name = "Default Weapon";
            //}
            while (string.IsNullOrWhiteSpace(name))
            {
                WriteLine("Weapon name cannot be empty. Please enter a valid name:");
                name = ReadLine();
            }
            name = string.Join(" ", name.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            WriteLine("Enter minimum damage:");
            int minDamage = int.TryParse(ReadLine(), out int parsedMinDamage) ? parsedMinDamage : 1;
            WriteLine("Enter maximum damage:");
            int maxDamage = int.TryParse(ReadLine(), out int parsedMaxDamage) ? parsedMaxDamage : 10;

            Weapon weapon = new Weapon(name, minDamage, maxDamage);

            WriteLine($"Weapon: \"{weapon.Name}\", Damage: {weapon.GetDamage()}, Durability: {weapon.Durability}");
        }
    }
}