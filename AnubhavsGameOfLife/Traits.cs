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
                // here we generate a trait
                var t = TraitFactory.GenerateTrait();
                // here if the trait is already there, we kind of leave it.
                if (!Persona.ContainsKey(t.Value))
                {
                    Persona[t.Value] = t;
                }
                // this leads to some Beings having lesser traits. But it all works out well.
            }
        }

        public Traits()
        {
            Instantiate();
        }
    }
}
