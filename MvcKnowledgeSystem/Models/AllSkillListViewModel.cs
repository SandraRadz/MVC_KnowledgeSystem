using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace MvcKnowledgeSystem.Models
{
    public class AllSkillListViewModel
    {
        public List<Skill> Skills;
        public SelectList Skill;
        public string ChoosedSkill { get; set; }
        public string ChooseString { get; set; }
    }
}
