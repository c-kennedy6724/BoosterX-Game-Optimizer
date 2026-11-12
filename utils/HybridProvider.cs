using System;

namespace App
{
    public class AsyncHandler
    {
        private int _state;

        public AsyncHandler(int seed) => _state = seed;

        public int compute(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 36) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new AsyncHandler(36);
            Console.WriteLine(obj.compute(36));
        }
    }
}
