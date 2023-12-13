using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Slot : MonoBehaviour
{
    public Item item;
    public UnityEngine.UI.Image image;

    public GameObject equpimentNotice;
    private bool IsEquip = false;

    public void SetItem(Item item)
    {
        this.item = item;
        if(item==null)
        {
            image.enabled = false;
            gameObject.name = "Empty";
        }
        else
        {
            image.enabled = true;
            image.gameObject.SetActive(true);
            gameObject.name = item.itemName;
            image.sprite = item.sprite;
        }
    }
    public void EquipItme()
    {
        IsEquip = !IsEquip;
        equpimentNotice.SetActive(IsEquip);
    }
}
