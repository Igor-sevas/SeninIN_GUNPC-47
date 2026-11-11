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
                "\n6. Замена слов");

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
                        string joinedStrings = MassiveString(strings);
                        WriteLine($"Объединенная строка: {joinedStrings}");
                        break;
                    case 6:
                        WriteLine("Введите строку:");
                        string str6 = ReadLine();
                        WriteLine("Введите слово, которое нужно заменить:");
                        string wordToReplace = ReadLine();
                        WriteLine("Введите слово, на которое нужно заменить:");
                        string replacementWord = ReadLine();
                        string replacedString = ReplaceWords(str6, wordToReplace, replacementWord);
                        WriteLine($"Результат выполнения: {replacedString}");
                        break;
                    default:
                        WriteLine("Неверный выбор. Пожалуйста, выберите действие от 1 до 6.");
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
            return $"Hello, {name}! You are {age} years old.";
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
        static string MassiveString(string[] str)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i > 0)
                    sb.Append(' ');
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

     public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            if (wordToReplace == null || replacementWord == null)
            {
                return "Введено пустое значение";
            }
            if (!inputString.Contains(wordToReplace)) 
            {
                return "Слово для замены не найдено в строке";
            }

            return inputString.Replace(wordToReplace, replacementWord);
        }
        
    }
}
