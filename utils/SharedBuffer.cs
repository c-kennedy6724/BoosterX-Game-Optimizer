using System;

namespace App
{
    public class AtomicSession
    {
        private int _state;

        public AtomicSession(int seed) => _state = seed;

        public int handle(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 89) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new AtomicSession(89);
            Console.WriteLine(obj.handle(89));
        }
    }
}
