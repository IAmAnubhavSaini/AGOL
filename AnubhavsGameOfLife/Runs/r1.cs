using System;
using System.Collections.Generic;

namespace AnubhavsGameOfLife.Runs
{
    /// <summary>
    /// Here, we will create 10^2 beings, and will tell what happens at the end of the communizing
    /// i.e. what sort of communities will we have? In This case we have pair.
    /// </summary>
    public class R1
    {
        private const int BeingCountUnderRun = 10;

        public static void Run()
        {
            var beings = new List<Being>();
            for (var i = 0; i < BeingCountUnderRun; ++i)
            {
                var b = new Being();
                beings.Add(b);
            }

            // bool HasCommunity = false;
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
