﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcKnowledgeSystem.Models
{
    public class UserParent
    {
        public User User { get; set; }
        public UserSkillViewModel GetUserSkillViewModel { get; set; }
    }
}
