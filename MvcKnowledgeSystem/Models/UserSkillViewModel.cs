using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcKnowledgeSystem.Models
{
    public class UserSkillViewModel
    {
        public List<User> Users;
        public SelectList Skill;
        public string UserSkill { get; set; }
        public string SearchString { get; set; }
    }
}
