using System.Linq;

namespace AnubhavsGameOfLife
{
    public class Being
    {
        public Traits Traits;

        public Being()
        {
            Traits = new Traits();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Being))
            {
                return false;
            }
            var matchedTraits = Traits.Persona.Count(trait => ((Being) obj).Traits.Persona.ContainsKey(trait.Key));
            return matchedTraits >= Traits.Persona.Count/2;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        


    }
}
