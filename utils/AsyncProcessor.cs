using System;

namespace App
{
    public class DynamicProcessor
    {
        private int _state;

        public DynamicProcessor(int seed) => _state = seed;

        public int collect(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 11) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new DynamicProcessor(11);
            Console.WriteLine(obj.collect(11));
        }
    }
}
