using AnubhavsGameOfLife.Interfaces;
using System;

namespace AnubhavsGameOfLife
{

    interface IMakeLifeGoOn
    {
        void MakeLife();
    }

    class Life : IMakeLifeGoOn, ISayDiagnosticThings
    {
        private double _age;
        private double _ageIncrement;
        private static readonly Random AgeIncrementFactorGenerator;


        static Life()
        {
            AgeIncrementFactorGenerator = new Random(1);
        }
        public void MakeLife()
        {
            _ageIncrement = 0.75 + 1*AgeIncrementFactorGenerator.NextDouble();
            _age += _ageIncrement;
        }

        public string SpillBeans()
        {
            return "Age: " + _age.ToString();
        }
    }
}
