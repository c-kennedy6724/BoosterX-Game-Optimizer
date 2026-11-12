using System;

namespace App
{
    public class DynamicWorker
    {
        private int _state;

        public DynamicWorker(int seed) => _state = seed;

        public int run(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 72) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new DynamicWorker(72);
            Console.WriteLine(obj.run(72));
        }
    }
}
