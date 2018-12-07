using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcKnowledgeSystem.Models
{
   
    public class User
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [Display(Name = "Ім'я")]
        public string name { get; set; }

        [Display(Name = "Статус")]
        [Required]
        public string role { get; set; }

        [Display(Name = "Уміння")]
        public string Skill { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [Display(Name = "Логін")]
        public string login { get; set; }

        [StringLength(5)]
        [Display(Name = "Пароль")]
        public string password { get; set; }

        public IList<UserSkill> UserSkills { get; set; }
    }
}
