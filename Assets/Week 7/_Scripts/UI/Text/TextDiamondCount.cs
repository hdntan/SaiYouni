using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDiamondCount : TextAbstact
{
    protected virtual void FixedUpdate()
    {
        this.LoadDiamondCount();
    }

    protected virtual void LoadDiamondCount()
    {
        ItemInventory item = InventoriesManager.Instance.Currency().FindItem(ItemCode.Diamond);
        string goldCount;
        if (item == null) goldCount = "0";
        else goldCount = item.itemCount.ToString();
        this.textPro.text = goldCount;

    }
}
