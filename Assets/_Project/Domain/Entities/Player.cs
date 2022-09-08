using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGoal.Domain
{
    public class Player
    {
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}