using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGoal.Domain.ValueObjects
{
    public class KitColor
    {
        public string HexCode { get; private set; }
        public KitColor(string hexCode)
        {
            if (string.IsNullOrEmpty(hexCode) || hexCode.Length != 6)
                throw new System.InvalidOperationException($"Invalid color: {hexCode}. Should be HTML color like, without #.");
            HexCode = hexCode;
        }
    }

}
