using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextExpPlayerCount : TextAbstact
{
    protected virtual void FixedUpdate()
    {
        this.LoadGoldCount();
    }

    protected virtual void LoadGoldCount()
    {
        ItemInventory item = InventoriesManager.Instance.Currency().FindItem(ItemCode.PlayerExp);
        string expPlayerCount;
        if (item == null) expPlayerCount = "0";
        else expPlayerCount = item.itemCount.ToString();
        this.textPro.text = expPlayerCount;

    }
}
