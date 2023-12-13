using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}
[Serializable]
public class CharacterStats
{
    public StatsChangeType statsChangeType;
    public string descript = "";
    public string ID = "";

    [Range(1f, 100f)] public float exp;
    [Range(1, 100)] public int maxHealth;
    [Range(1, 100)] public int attack;
    [Range(1, 100)] public int defense;
    [Range(1, 100)] public int critical;
    public int gold;
    public int level;

}
