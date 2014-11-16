using System;
using System.Collections.Generic;

namespace AnubhavsGameOfLife
{
    public static class TraitFactory
    {
        private static readonly Random RandomNumberGenerator;
        private const int UpperLimitForRandom = 100;
        private const int LowerLimitForRandom = 0;

        static TraitFactory()
        {
            RandomNumberGenerator = new Random(1);
        }
        public static Trait GenerateTrait()
        {
            var t = (RandomNumberGenerator.Next(LowerLimitForRandom, UpperLimitForRandom) * (Convert.ToInt32(DateTime.Now.Ticks & 0x000000007FFFFFFF))) % UpperLimitForRandom;
            if (t < 0)
            {
                t *= -1;
            }
            return new Trait(t);
        }
    }
    public class Trait
    {

        public int Value { get; private set; }

        public Trait(int val)
        {
            Value = val;
        }
    }

    public class Traits
    {
        private const int NumberOfTraitsABeingCanHave = 15;
        public Dictionary<int, Trait> Persona;

        private void Instantiate()
        {
            Persona = new Dictionary<int, Trait>();
            for (var i = 0; i < NumberOfTraitsABeingCanHave; ++i)
            {
                var t = TraitFactory.GenerateTrait();
                if (!Persona.ContainsKey(t.Value))
                {
                    Persona[t.Value] = t;
                }
                // Dut to skipping already existing traits, some Beings end up having lesser traits. 
                // But it all works out well, as the theory is: lesser traits, more chances of 
                // connection with other beings. Read : theory of few flaws.txt
            }
        }

        public Traits()
        {
            Instantiate();
        }
    }
}
