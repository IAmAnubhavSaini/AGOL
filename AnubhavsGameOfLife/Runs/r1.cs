using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnubhavsGameOfLife.Runs
{
    /// <summary>
    /// Here, we will create 10^3 beings, and will tell what happens at the end of the communizing
    /// i.e. what sort of communities will we have? In This case we have pair.
    /// </summary>
    public class r1
    {
        private static int beingCountUnderRun = 10;
        public static void Run()
        {
            Being b;
            List<Being> beings = new List<Being>();
            for (int i = 0; i < beingCountUnderRun; ++i)
            {
                b = new Being();
                beings.Add(b);
            }

            // bool HasCommunity = false;
            Community Com;
            List<Community> AllCommunities = new List<Community>();
            for (int i = 0; i < beings.Count -1; ++i)
            {
                for (int j = i + 1; j < beings.Count; ++j)
                {
                    if (beings[i].Equals(beings[j]))
                    {
                        Com = new Community();
                        Com.AddIndividual(beings[i]);
                        Com.AddIndividual(beings[j]);
                        AllCommunities.Add(Com);
                        Com.FillCommonTraits(beings[i], beings[j]);
                        
                        //if (!HasCommunity)
                        //{
                        //    Com = new Community();
                        //    Com.AddIndividual(beings[i]);
                        //    Com.AddIndividual(beings[j]);
                        //    HasCommunity = true;
                        //}
                        //else
                        //{
                        //    Com.AddIndividual(beings[j]);
                        //}
                    }
                }
            }

            Console.WriteLine("Communities (pairs) : {0}\n", AllCommunities.Count);
            foreach (var com in AllCommunities)
            {
                com.PrintCommonTraits();
            }
        }
    }
}
