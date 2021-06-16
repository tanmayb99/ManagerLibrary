using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLibrary
{
    class TeamClass
    {
        public List<PersonClass> TeamMembers { get; set; } = new List<PersonClass>(); // in C# 6.0, list can be initialized here (at the end of the property), otherwise before we have to do it in constructor
        public string TeamName { get; set; }
    }
}
