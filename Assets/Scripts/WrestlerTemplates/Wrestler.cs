using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Wrestler")]
public class Wrestler : ScriptableObject
{
    public Sprite SpriteIcon;
    public EnumWrestlerType FightingStyle;

    [Range(0, 100)]
    public int Cardio, Resistance, Speed, Strength;
}
