﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnubhavsGameOfLife
{
    interface IMakeLifeGoOn
    {
        void MakeLife();
    }

    class Life : IMakeLifeGoOn
    {
        private double ageLeft;
        private double ageIncrement;
        private static Random ageIncrementFactorGenerator;


        static Life()
        {
            ageIncrementFactorGenerator = new Random(1);
        }
        public void MakeLife()
        {
            ageIncrement = 0.75 + 1*ageIncrementFactorGenerator.NextDouble();
        }
    }
}
