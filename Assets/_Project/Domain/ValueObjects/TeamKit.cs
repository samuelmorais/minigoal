using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGoal.Domain.ValueObjects
{
    public class TeamKit
    {
        public enum PartColor { Color1, Color2, Color3}
        public KitColor Color1 { get; private set; }
        public KitColor Color2 { get; private set; }
        public KitColor Color3 { get; private set; }
        public PartColor ShirtMainColor { get; private set; }
        public PartColor ShirtSecundaryDetailsColor { get; private set; }
        public PartColor ShortMainColor { get; private set; }
        public PartColor ShortSecundaryDetailsColor { get; private set; }
        public PartColor SocksMainColor { get; private set; }
        public PartColor SocksSecondaryDetailsColor { get; private set; }
    }
}