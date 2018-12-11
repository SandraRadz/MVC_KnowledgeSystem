using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcKnowledgeSystem.Models
{
    public class Skill
    {
        public int ID { get; set; }

        [Display(Name = "Назва")]
        public string name { get; set; }
    }
}
