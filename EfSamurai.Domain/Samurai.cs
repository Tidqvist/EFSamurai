using System;
using System.Collections.Generic;

namespace EfSamurai.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Length { get; set; }
        public int? Weight { get; set; }
        public SpecialMove SpecialMove { get; set; }
        public List<Quote> Quotes { get; set; }

    }
}
