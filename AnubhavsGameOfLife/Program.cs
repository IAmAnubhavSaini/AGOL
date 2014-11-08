using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnubhavsGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Being b1 = new Being();
            Being b2 = new Being();
            int i = 0;
            while(i < 10000)
            {
                i++;
                if (!b1.Equals(b2))
                {
                   // Console.WriteLine(i.ToString() + ". Being b1 and b2 don't have compatibility.");
                }
                else
                {
                    Console.WriteLine(i.ToString() + ". Being b1 and b2 have compatibility.");
                }
                b1 = new Being();
                b2 = new Being();
            }
        }
    }
}
