using System;

namespace AnubhavsGameOfLife.Runs
{

    public class R0
    {
		static class Constants{
			public const int MaxNumberOfBeings = 10000;
		}

		public static void Run()
        {
            var b1 = new Being();
            var b2 = new Being();
            var i = 0;
            while (i < Constants.MaxNumberOfBeings)
            {
                i++;
                if (b1.Equals(b2))
                {
                    Console.WriteLine(i + ". Being b1 and b2 have compatibility.");
                }
                b1 = new Being();
                b2 = new Being();
            }
        }
    }
}
