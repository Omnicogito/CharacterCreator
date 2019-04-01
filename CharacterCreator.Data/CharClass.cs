using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterCreator.Data
{
    public class CharClass
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public bool SpellCaster { get; set; }
        public int HitPointsFirstLevel { get; set; }
        public string Proficiencies { get; set; }

    }
}