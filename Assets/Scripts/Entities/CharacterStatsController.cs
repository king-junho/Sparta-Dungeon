using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsController : MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats;
    public CharacterStats CurrentStats { get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();
    public List<Item> items;

    private void Awake()
    {
        UpdateCharacterStats();
    }
    private void UpdateCharacterStats()
    {
        CurrentStats = new CharacterStats();
        CurrentStats.statsChangeType = baseStats.statsChangeType;
        CurrentStats.exp = baseStats.exp;
        CurrentStats.maxHealth = baseStats.maxHealth;
        CurrentStats.attack = baseStats.attack;
        CurrentStats.defense = baseStats.defense;
        CurrentStats.critical = baseStats.critical;
        CurrentStats.gold= baseStats.gold;
        CurrentStats.level = baseStats.level;
        CurrentStats.ID=baseStats.ID;
        CurrentStats.descript = baseStats.descript;
    }


}
