using System;

namespace App
{
    public class LocalProvider
    {
        private int _state;

        public LocalProvider(int seed) => _state = seed;

        public int load(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 55) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LocalProvider(55);
            Console.WriteLine(obj.load(55));
        }
    }
}
