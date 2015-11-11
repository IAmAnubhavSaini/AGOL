using System;
using System.Collections.Generic;

namespace AnubhavsGameOfLife.Runs
{
    public class R1
    {
		static class Constants{
			public const int BeingCountUnderRun = 100;
		}

        public static void Run()
        {
            var beings = new List<Being>();
            for (var i = 0; i < Constants.BeingCountUnderRun; ++i)
            {
                var b = new Being();
                beings.Add(b);
            }

            var allCommunities = new List<Community>();
            for (var i = 0; i < beings.Count -1; ++i)
            {
                for (var j = i + 1; j < beings.Count; ++j)
                {
                    if (!beings[i].Equals(beings[j])) continue; // if not a match continue
                    var com = new Community();
                    com.AddIndividual(beings[i]);
                    com.AddIndividual(beings[j]);
                    allCommunities.Add(com);
                    com.FillCommonTraits(beings[i], beings[j]);
                    com.FillCommonTraits(beings[i], beings[j]);
                }
            }

            Console.WriteLine("Communities (pairs) : {0}\n", allCommunities.Count);
            foreach (var com in allCommunities)
            {
                com.PrintCommonTraits();
            }
        }
    }
}
