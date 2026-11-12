using System;

namespace App
{
    public class SmartController
    {
        private int _state;

        public SmartController(int seed) => _state = seed;

        public int handle(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 21) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SmartController(21);
            Console.WriteLine(obj.handle(21));
        }
    }
}
