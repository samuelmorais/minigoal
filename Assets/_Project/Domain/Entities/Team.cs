using System.Collections;
using System.Collections.Generic;
using MiniGoal.Domain.ValueObjects;
using UnityEngine;

namespace MiniGoal.Domain
{
    public class Team
    {
        public string Name { get; private set; }
        public TeamKit Kit { get; private set; }
        public Team(string name)
        {
            Name = name;
        }
        public void SetKit(TeamKit kit)
        {
            kit = Kit;
        }
    }
}

