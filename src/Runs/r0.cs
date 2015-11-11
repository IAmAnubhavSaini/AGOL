using System;

namespace AnubhavsGameOfLife.Runs
{
    public class R0
    {
        public static void Run()
        {
            var b1 = new Being();
            var b2 = new Being();
            var i = 0;
            while (i < 10000)
            {
                i++;
                if (b1.Equals(b2))
                {
                    Console.WriteLine(i.ToString() + ". Being b1 and b2 have compatibility.");
                }
                b1 = new Being();
                b2 = new Being();
            }
        }
    }
}
