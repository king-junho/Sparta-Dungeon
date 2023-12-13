using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Attatk,
    Defense,
    Hp,
    Critical,
    Consumables,
    Etc,
}

[System.Serializable]
public class Item
{
    public ItemType itemType;
    public string itemName;
    public Sprite sprite;
    public int itemStats;

    public bool Use()
    {
        return false;
    }
}
