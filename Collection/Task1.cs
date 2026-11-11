
using static System.Console;

namespace Collection
{
    internal class Task1
    {
        public void TaskLoop()
        {
            List<string> poem = new List<string>()
            {
                "Я помню чудное мгновенье:",
                "Как мимолетное виденье,"
            };

            WriteLine(string.Join("\n", poem));



            WriteLine("Ой, а дальше я забыл... Введи последнюю строку:");
          

            string forgottenLine = ReadLine();

            if (string.IsNullOrWhiteSpace(forgottenLine))
            {
                WriteLine("Ошибка: строка не может быть пустой.");
                return;
            }

            if (poem.Contains(forgottenLine))
            {
                WriteLine("Ошибка: эта строка уже есть в стихотворении.");
                return;
            }
                      
            WriteLine("Отлично!");
            poem.Add(forgottenLine);

          WriteLine(string.Join("\n", poem));

          
            WriteLine("Так, что-то тут опять не то... Введи вторую строку:");
           

            string newLine = ReadLine();

            if (string.IsNullOrWhiteSpace(newLine))
            {
                WriteLine("Ошибка: строка не может быть пустой.");
                return;
            }

            if (poem.Contains(newLine))
            {
                WriteLine("Ошибка: эта строка уже есть в стихотворении.");
                return;
            }

                      WriteLine("Готово!");

            poem.Insert(1, newLine); 

           
            WriteLine("Вот теперь все правильно, наверное!");
      

            WriteLine(string.Join("\n", poem));

            WriteLine("Введите menu для возврата в меню, либо введите exit для выхода из программы");
            

            string input = ReadLine();

            if (input == "menu")
            {
                WriteLine("Возврат в меню");
            }
            else if (input == "exit")
            {
                WriteLine("Выход из программы");
                Environment.Exit(0);
            }
            else
            {
                WriteLine("Неверный ввод. Возврат в меню.");
            }
        }
    }
}