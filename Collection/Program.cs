using static System.Console;
namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Выберите задачу (1-3):\n" +
                "1. Задача 1. Дополнить строки четверостишья А.С. Пушкина\n" +
                "2. Задача 2. Создание словаря студентов и их оценок.\n" +
                "3. Задача 3. Cоздание списка целых чисел и двусвязного списка.\n" +
                "4. Введите 0 для выхода");
                string choice = ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Task1 task1 = new Task1();
                        task1.TaskLoop();
                        break;
                    case "2":
                        Task2 task2 = new Task2();
                        task2.TaskLoop();
                        break;
                    case "3":
                        LinkedListTask task3 = new LinkedListTask();
                        task3.TaskLoop();
                        break;
                    default:
                        WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
