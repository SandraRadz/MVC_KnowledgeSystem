using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcKnowledgeSystem.Models
{
 
    public class Skill
    {
        public int SkillId { get; set; }
        public string CourseName { get; set; }

        public IList<UserSkill> UserSkills { get; set;}

    }
}
