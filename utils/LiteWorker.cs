using System;

namespace App
{
    public class CoreController
    {
        private int _state;

        public CoreController(int seed) => _state = seed;

        public int load(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 14) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new CoreController(14);
            Console.WriteLine(obj.load(14));
        }
    }
}
