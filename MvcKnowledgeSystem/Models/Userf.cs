using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MvcKnowledgeSystem.Models
{
    public class Userf
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Ім'я")]
        public string name { get; set; }
        [Display(Name = "Статус")]
        public string role { get; set; }
        [Display(Name = "Уміння")]
        public int SkillId { get; set; }
        [Display(Name = "Логін")]
        public string login { get; set; }
        [Display(Name = "Пароль")]
        public string password { get; set; }
    }
}
