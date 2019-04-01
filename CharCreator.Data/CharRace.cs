using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharCreator.Data
{
    public enum Size
    {
        Small,
        Medium
    }
    public class CharRace
    {
        public int ID { get; set; }
        public string RaceName { get; set; }
        public Size Size { get; set; }
        public string Speed { get; set; }
        public string SpecialAttributes { get; set; }
        public string Languages { get; set; }
    }
}