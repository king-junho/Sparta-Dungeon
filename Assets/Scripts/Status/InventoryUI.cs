using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Transform slotRoot;
    public ItemBuffer itemBuffer;
    private List<Slot> slots;
    private void Start()
    {
        int slotCount = slotRoot.childCount;
        slots = new List<Slot>();   

        for(int i=0; i<slotCount; i++)
        {
            var slot = slotRoot.GetChild(i).GetComponent<Slot>();
            if(i<itemBuffer.items.Count)
            {
                slot.SetItem(itemBuffer.items[i]);
            }
            slots.Add(slot);
        }
    }

}
