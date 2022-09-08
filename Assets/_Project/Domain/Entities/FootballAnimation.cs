using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGoal.Domain
{
    public class FootballAnimation
    {
        public Team TeamOfTheMainPlayer { get; private set; }
        public Player MainPlayer { get; private set; }
        public string MotionClip { get; private set; }
        public FootballAnimation(string motionClip, Team team, Player player)
        {
            MotionClip = motionClip;
            TeamOfTheMainPlayer = team;
            MainPlayer = player;
        }
    }
}