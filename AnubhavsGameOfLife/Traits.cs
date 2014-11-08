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

        static TraitFactory()
        {
            randomNumberGenerator = new Random(1);
        }
        public static Trait GenerateTrait()
        {
            return new Trait(randomNumberGenerator.Next(1, 100));
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

        public Dictionary<int, Trait> Persona;

        private void Instantiate()
        {
            Persona = new Dictionary<int, Trait>();
            Trait t;
            for (int i = 0; i < 10; ++i)
            {
                t = TraitFactory.GenerateTrait();
                if (!Persona.ContainsKey(t.Value))
                {
                    Persona[t.Value] = t;
                }
            }
        }

        public Traits()
        {
            Instantiate();
        }
    }
}
