using System;

namespace App
{
    public class SecureFactory
    {
        private int _state;

        public SecureFactory(int seed) => _state = seed;

        public int flush(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 44) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SecureFactory(44);
            Console.WriteLine(obj.flush(44));
        }
    }
}
