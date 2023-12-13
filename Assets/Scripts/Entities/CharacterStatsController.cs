using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterStatsController : MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats;
    private GameManager instance;
    public CharacterStats CurrentStats { get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();
    public List<Item> items;

    private void Awake()
    {
        InitCharacterStats();
    }
    private void Start()
    {
        instance = GameManager.instance;
    }
    private void InitCharacterStats()
    {
        CurrentStats = baseStats;
    }

    public void UpdateItemStats(Item item, bool isEquip)
    {
            switch (item.itemType)
        {
            
            case ItemType.Attatk:
                CurrentStats.attack += isEquip ? item.itemStats : -item.itemStats;
                break;
            case ItemType.Defense:
                CurrentStats.defense += isEquip ? item.itemStats : -item.itemStats;
                break;
            case ItemType.Hp:
                CurrentStats.maxHealth += isEquip ? item.itemStats : -item.itemStats;
                break;
            case ItemType.Critical:
                CurrentStats.critical += isEquip ? item.itemStats : -item.itemStats;
                break;
            case ItemType.Consumables:
                //TODO
                break;
            case ItemType.Etc:
                //TODO
                break;
        }
        instance.SetUI();


    }



}
