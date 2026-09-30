using static System.Console;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 1. Массив с числами Фибоначчи:");
            ResetColor();
            int[] fibonacci = new int[8];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
 
 for (int i = 0; i < fibonacci.Length; i++)
{
    Write(fibonacci[i] + " ");
}
WriteLine();
 
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 2. Массив с месяцами:");
            ResetColor();

            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August",
             "September", "October", "November", "December"};
            WriteLine(string.Join(", ", months));

            ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 3. Двумерный массив");
            ResetColor();
            int[,] matrix = new int[3, 3];

for (int i = 0; i < 3; i++)          // строка (степень)
{
    for (int j = 0; j < 3; j++)      // столбец (число 2, 3, 4)
    {
        matrix[i, j] = (int)Math.Pow(j + 2, i + 1);
    }
}

// Вывод матрицы
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write(matrix[i, j] + "\t");
    }
    WriteLine();
}

            ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 4. Ломанный массив");
            ResetColor();

            double[][] jaggedArray = new double[3][]
            {
    new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 },
    new double[] { Math.E, Math.PI },
    new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }
            };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                WriteLine(string.Join(", ", jaggedArray[i]));
            }

            ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача Б. Задание 5. Скопируйте первые 3 элемента первого массива во второй");
            ResetColor();

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            WriteLine("Первый массив: " + string.Join(", ", array));
            WriteLine("Второй массив: до изменения " + string.Join(", ", array2));

            Array.Copy(array, 0, array2, 0, 3);

            WriteLine("Второй массив после изменения: " + string.Join(", ", array2));

            ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача Б. Задание 6. Изменение размера массива");
            ResetColor();
            WriteLine("Размер массива array до изменения: " + array.Length);
            Array.Resize(ref array, array.Length * 2);
            WriteLine("Размер массива array после изменения: " + array.Length);
        }
    }
}