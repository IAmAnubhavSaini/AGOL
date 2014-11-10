using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int matchedTraits = 0;
            // this change makes the weightage important.
            foreach (var trait in Traits.Persona.Where(r=>r.Value.Weightage>0))
            {
                if (((Being)obj).Traits.Persona.ContainsKey(trait.Key))
                {
                    matchedTraits++;
                }
            }
            if(matchedTraits >= Traits.Persona.Count/2)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        


    }
}
