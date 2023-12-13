using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<Item> items;
    private void Awake()
    {
        items = new List<Item>();
        instance = this;
    }
}
