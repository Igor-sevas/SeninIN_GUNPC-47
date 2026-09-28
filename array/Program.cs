using System.Drawing;
using static System.Console;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 1. Массив с числами Фибоначчи:");
            Console.ResetColor();
            int[] fibonacci = new int[10];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                int result = fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                WriteLine(string.Join(", ", result));
            }

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 2. Массив с месяцами:");
            Console.ResetColor();

            string[] months = new string[12];
            {
                months[0] = "January";
                months[1] = "February";
                months[2] = "March";
                months[3] = "April";
                months[4] = "May";
                months[5] = "June";
                months[6] = "July";
                months[7] = "August";
                months[8] = "September";
                months[9] = "October";
                months[10] = "November";
                months[11] = "December";
            }
            ;
            WriteLine(string.Join(", ", months));

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 3. Двумерный массив");
            Console.ResetColor();
            int[,] matrix = new int[3, 3]
            {
    { 2, 3, 4 },
    { 4, 9, 16 },
    { 8, 27, 64 }
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача А.Задание 4. Ломанный массив");
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача Б. Задание 5. Скопируйте первые 3 элемента первого массива во второй");
            Console.ResetColor();

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            WriteLine("Первый массив: " + string.Join(", ", array));
            WriteLine("Второй массив: до изменения " + string.Join(", ", array2));

            Array.Copy(array, 0, array2, 0, 3);

            WriteLine("Второй массив после изменения: " + string.Join(", ", array2));

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Задача Б. Задание 6. Изменение размера массива");
            Console.ResetColor();
            WriteLine("Размер массива array до изменения: " + array.Length);
            Array.Resize(ref array, array.Length * 2);
            WriteLine("Размер массива array после изменения: " + array.Length);
        }
    }
}