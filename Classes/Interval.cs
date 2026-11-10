using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Classes
{
    internal class Interval
    {
        private static readonly Random _random = new Random();
        public float minValue { get; }
        public float maxValue { get; }

        public Interval(int minValue, int maxValue)
        {

            if (minValue < 0)
            {
                Console.WriteLine("Некорректные данные: minValue отрицательное, заменено на 0.");
                minValue = 0;
            }
            if (maxValue < 0)
            {
                Console.WriteLine("Некорректные данные: maxValue отрицательное, заменено на 0.");
                maxValue = 0;
            }


            if (minValue > maxValue)
            {
                Console.WriteLine("Некорректные данные: minValue > maxValue, значения поменяны местами.");
                int tmp = minValue;
                minValue = maxValue;
                maxValue = tmp;
            }


            if (minValue == maxValue)
            {
                Console.WriteLine("Некорректные данные: minValue == maxValue, maxValue увеличено на 10.");
                maxValue += 10;
            }

            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public float Get()
        {
            return minValue + (float)_random.NextDouble() * (maxValue - minValue);
        }
    }
}

