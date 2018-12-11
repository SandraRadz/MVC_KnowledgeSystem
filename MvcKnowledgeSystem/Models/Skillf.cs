using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MvcKnowledgeSystem.Models
{
    public class Skillf
    {
        [Key]
        public int SkillId { get; set; }

        [Display(Name = "Назва")]
        [Required] public string Name { get; set; }
    }
}
