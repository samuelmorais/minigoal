using System.Collections.Generic;
using UnityEngine;

namespace MiniGoal.Domain
{
    public class FootballPlay : MonoBehaviour
    {
        public List<FootballAnimation> Animations { get; private set; }
        public FootballPlay()
        {
            Animations = new List<FootballAnimation>();
        }
    }
}

