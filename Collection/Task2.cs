
using static System.Console;

namespace Collection
{
    internal class Task2
    {
        private Dictionary<string, int> students = new Dictionary<string, int>();

        public void TaskLoop()
        {
            while (true)
            {
                ForegroundColor = System.ConsoleColor.Blue;
                WriteLine("Задание 2: Словарь студентов");
                WriteLine("1 - Добавить студента");
                WriteLine("2 - Найти студента");
                WriteLine("3 - Просмотреть всех");
                WriteLine("exit - вернуться в меню");
                ResetColor();
                Write("Выбор: ");

                string input = ReadLine();

                if (input == "0")
                {
                    WriteLine("Возврат в меню...");
                    return;
                }

                if (!int.TryParse(input, out int choice))
                {
                    WriteLine("Неверный ввод. Введите число или 0.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        FindStudent();
                        break;
                    case 3:
                        ShowAll();
                        break;
                    default:
                        WriteLine("Неверный выбор.");
                        break;
                }
            }
        }

        private void AddStudent()
        {
            Write("Введите имя студента: ");
            string name = ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                WriteLine("Имя не может быть пустым.");
                return;
            }

            Write("Введите оценку (2–5): ");
            if (!int.TryParse(ReadLine(), out int estimation)
                || estimation < 2 || estimation > 5)
            {
                WriteLine("Ошибка: оценка должна быть числом от 2 до 5.");
                return;
            }

            if (students.ContainsKey(name))
                students[name] = estimation;
            else
                students.Add(name, estimation);

            WriteLine($"Добавлено: {name} — {estimation}");
        }

        private void FindStudent()
        {
            Write("Введите имя для поиска: ");
            string name = ReadLine();

            if (students.TryGetValue(name, out int estimation))
                WriteLine($"Оценка {name}: {estimation}");
            else
                WriteLine($"Студента с именем '{name}' не существует.");
        }

        private void ShowAll()
        {
            if (students.Count == 0)
            {
                WriteLine("Список пуст.");
                return;
            }

            foreach (var pair in students)
                WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}