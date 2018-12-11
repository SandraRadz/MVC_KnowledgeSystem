using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcKnowledgeSystem.Models
{
    

    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Ім'я")]
        public string name { get; set; }
        [Display(Name = "Статус")]
        public string role { get; set; }
        [Display(Name = "Уміння")]
        public string Skill { get; set; }
        [Display(Name = "Логін")]
        public string login { get; set; }
        [Display(Name = "Пароль")]
        public string password { get; set; }
    }

}
