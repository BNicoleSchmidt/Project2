using System;
using System.Collections.Generic;
using System.Text;

namespace MeramecNetFlixProject.UnitTest
{
    public class RandomTester
    {
        private readonly Random _random;
        private readonly HashSet<object> _used = new HashSet<object>();

        private const string RandomStringCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 ";
        private static readonly DateTime MinDate = new DateTime(1900, 1, 1);
        private static readonly DateTime MaxDate = new DateTime(2101, 1, 1);

        public RandomTester()
        {
            _random = new Random();
        }

        public RandomTester(int seed)
        {
            _random = new Random(seed);
        }

        public Random Random { get { return _random; } }


        private T DoUntilUnseen<T>(Func<T> func)
        {
            while (true)
            {
                T result = func();
                if (_used.Add(result))
                    return result;
            }
        }

        public int Int32(int maxValue = 1000)
        {
            return Int32(1, maxValue);
        }

        public int Int32(int minValue, int maxValue)
        {
            if (minValue > maxValue) throw new ArgumentOutOfRangeException();
            return DoUntilUnseen(() =>
            {
                return minValue + _random.Next(maxValue - minValue);
            });
        }

        public string Case(string value)
        {
            var returnValue = new StringBuilder();
            foreach (var t in value)
            {
                var r = _random.Next(1, 3);
                returnValue.Append(r % 2 == 0 ? t.ToString().ToUpper() : t.ToString().ToLower());
            }
            return returnValue.ToString();
        }

        public decimal Decimal(int maxValue = 1000)
        {
            if (maxValue < 0) throw new ArgumentOutOfRangeException("maxValue");
            return DoUntilUnseen(() =>
            {
                return (decimal)(_random.NextDouble() * maxValue);
            });
        }

        public double Double(double maxValue = 1000)
        {
            if (maxValue < 0) throw new ArgumentOutOfRangeException("maxValue");
            return DoUntilUnseen(() =>
            {
                return _random.NextDouble() * maxValue;
            });
        }

        public double Double(double minValue, double maxValue)
        {
            if (minValue > maxValue) throw new ArgumentOutOfRangeException();
            return DoUntilUnseen(() =>
            {
                return minValue + _random.NextDouble() * (maxValue - minValue);
            });
        }

        public string String(int length = 20)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length");
            return DoUntilUnseen(() =>
            {
                var sb = new StringBuilder();
                while (sb.Length < length)
                {
                    char character;
                    do
                    {
                        int index = _random.Next(RandomStringCharacters.Length);
                        character = RandomStringCharacters[index];
                        // don't begin or end with whitespace
                    } while ((sb.Length == 0 || sb.Length == length - 1) && Char.IsWhiteSpace(character));
                    sb.Append(character);
                }
                return sb.ToString();
            });
        }

        public List<T> List<T>(int length = 20) where T : new()
        {
            var list = new List<T>(length);
            while (list.Count < length)
                list.Add(new T());
            return list;
        }

        public List<T> List<T>(Func<T> factory)
        {
            return List(20, factory);
        }

        public List<T> List<T>(int length, Func<T> factory)
        {
            var list = new List<T>(length);
            while (list.Count < length)
                list.Add(factory());
            return list;
        }

        public List<T> List<T>(int length, Func<int, T> factory)
        {
            var list = new List<T>(length);
            while (list.Count < length)
                list.Add(factory(list.Count));
            return list;
        }

        public void Shuffle<T>(IList<T> list)
        {
            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = _random.Next(i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        public DateTime Date()
        {
            var days = (MaxDate - MinDate).Days;
            return DoUntilUnseen(() =>
            {
                return MinDate.AddDays(_random.Next(days));
            });
        }
    }
}