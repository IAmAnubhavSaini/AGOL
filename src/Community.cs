﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AnubhavsGameOfLife
{
    public class Community
    {
        List<Being> Individuals { get; set; }
        List<Trait> CommonTraits { get; set; }

        public Community()
        {
            Individuals = new List<Being>();
            CommonTraits = new List<Trait>();
        }

        public void PrintCommonTraits()
        {
            Console.WriteLine("Printing common traits: ");
            foreach (var t in CommonTraits)
            {
                Console.Write(t.Value + ", ");
            }
            Console.WriteLine("\n");
        }
        internal void AddIndividual(Being being)
        {
            Individuals.Add(being);
        }
        internal void FillCommonTraits(Being b1, Being b2)
        {
            foreach (var t in b1.Traits.Persona.Where(t => b2.Traits.Persona.Any(u => t.Key == u.Key)))
            {
                CommonTraits.Add(new Trait(t.Key));
            }
        }
    }
}
