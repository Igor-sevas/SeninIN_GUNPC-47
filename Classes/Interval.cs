using static System.Console;
namespace Classes
{
    internal struct Interval
    {
        private static readonly Random _random = new Random();
        public float Min { get; }
        public float Max { get; }

        public Interval(float minValue, float maxValue)
        {

            if (minValue < 0)
            {
                WriteLine("Некорректные данные: minValue отрицательное, заменено на 0.");
                minValue = 0;
            }
            if (maxValue < 0)
            {
                WriteLine("Некорректные данные: maxValue отрицательное, заменено на 0.");
                maxValue = 0;
            }


            if (minValue > maxValue)
            {
                WriteLine("Некорректные данные: minValue > maxValue, значения поменяны местами.");
                (minValue, maxValue) = (maxValue, minValue);
            }


            if (minValue == maxValue)
            {
                WriteLine("Некорректные данные: minValue == maxValue, maxValue увеличено на 10.");
                maxValue += 10;
            }

            Min = minValue;
            Max = maxValue;
        }

        public float Get()
        {
            return Min + (float)_random.NextDouble() * (Max - Min);
        }
    }
}

