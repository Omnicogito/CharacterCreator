using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharCreator.Data
{
    public enum ExperienceLevel
    {
        Novice, Beginner, Intermediate, Advanced
    };
    public class Player
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }

        public virtual ICollection<Character> Characters { get; set; }

    }
}