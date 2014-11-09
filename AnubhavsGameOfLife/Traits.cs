using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnubhavsGameOfLife
{
    public static class TraitFactory
    {
        private static Random randomNumberGenerator;
        private static int upperLimitForRandom = 100;
        private static int lowerLimitForRandom = 0;
        static TraitFactory()
        {
            randomNumberGenerator = new Random(1);
        }
        public static Trait GenerateTrait()
        {
            int t = (randomNumberGenerator.Next(lowerLimitForRandom, upperLimitForRandom) * (Convert.ToInt32(DateTime.Now.Ticks & 0x000000007FFFFFFF))) % upperLimitForRandom;
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
        private int numberOfTraitsABeingCanHave = 15;
        public Dictionary<int, Trait> Persona;

        private void Instantiate()
        {
            Persona = new Dictionary<int, Trait>();
            Trait t;
            for (int i = 0; i < numberOfTraitsABeingCanHave; ++i)
            {
                // here we generate a trait
                t = TraitFactory.GenerateTrait();
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
