using System.Text;
using static System.Console;
namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Выберите действие:" +
                "\n1. Конкатенация строк" +
                "\n2. Приветствие пользователя" +
                "\n3. Информация о строке" +
                "\n4. Первые пять символов" +
                "\n5. Объединение массива строк" +
                "\n6. Замена слов" +
                "\n0. Выход из программы"
                );

                int choice = int.TryParse(ReadLine(), out choice) ? choice : 0;

                switch (choice)
                {
                    case 1:
                        WriteLine("Введите первую строку:");
                        string str1 = ReadLine();
                        WriteLine("Введите вторую строку:");
                        string str2 = ReadLine();
                        string result = ConcatStrings(str1, str2);
                        WriteLine(result);
                        break;
                    case 2:
                        WriteLine("Введите Ваше имя:");
                        string name = ReadLine();
                        name = string.IsNullOrEmpty(name) ? "Аноним" : name;
                        WriteLine("Введите Ваш возраст:");
                        int age = int.TryParse(ReadLine(), out age) ? age : 0;
                        string greeting = GreetUser(name, age);
                        WriteLine(greeting);
                        break;
                    case 3:
                        WriteLine("Введите строку о которой хотите получить информацию:");
                        string str = ReadLine();
                        string info = GetStringInfo(str);
                        WriteLine(info);
                        break;
                    case 4:
                        WriteLine("Введите строку:");
                        string str4 = ReadLine();
                        string fiveSymbols = GetFiveSymbols(str4);
                        WriteLine($"Первые пять символов: {fiveSymbols}");
                        break;
                    case 5:
                        WriteLine("Введите строки, разделенные пробелом:");
                        string[] strings = ReadLine().Split(' ');
                        StringBuilder joinedStrings = JoinWords(strings);
                        WriteLine($"Объединенная строка: {joinedStrings.ToString()}");
                        break;
                    case 6:
                        WriteLine("Введите строку:");
                        string input = ReadLine();
                        string str6 = string.IsNullOrEmpty(input) ? "Строка по умолчанию" : input;
                        WriteLine("Введите слово, которое нужно заменить:");
                        string wordToReplace = ReadLine();
                        WriteLine("Введите слово, на которое нужно заменить:");
                        string replacementWord = ReadLine();
                        bool success = TryReplaceWords(str6, wordToReplace, replacementWord, out string replacedString);
                        if (success)
                        {
                            WriteLine($"Результат выполнения: {replacedString}");
                        }
                        else
                        {
                            WriteLine("Замена невозможна: пустая строка или пустое слово для замены.");
                        }
                        break;
                    case 0:
                        WriteLine("Выход из программы.");

                        return;
                    default:
                        WriteLine("Неверный выбор. Пожалуйста, выберите действие от 0 до 6.");
                        break;
                }
            }
        }
        static string ConcatStrings(string str1, string str2)
        {

            return str1 + str2;
        }

        static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!" +
                $"\nYou are {age} years old.";
        }

        static string GetStringInfo(string str)
        {
            return $"Строка \"{str}\" состоит из {str.Length} символов." + Environment.NewLine +
           $"Строка в верхнем регистре: {str.ToUpper()}" + Environment.NewLine +
            $"Строка в нижнем регистре: {str.ToLower()}";
        }
        static string GetFiveSymbols(string str)
        {
            return str.Substring(0, Math.Min(5, str.Length));
        }
        static StringBuilder JoinWords(string[] str)
        {
            var sb = new StringBuilder();
            sb.AppendJoin(" ", str);
            return sb;
        }


        public static bool TryReplaceWords(
    string inputString,
    string wordToReplace,
    string replacementWord,
    out string result)
        {
            result = inputString;

            if (string.IsNullOrEmpty(inputString) ||
                string.IsNullOrEmpty(wordToReplace) ||
                replacementWord == null)
            {
                
                return false;   // замена невозможна
            }

            result = inputString.Replace(wordToReplace, replacementWord);
            return true;
        }

    }
}
