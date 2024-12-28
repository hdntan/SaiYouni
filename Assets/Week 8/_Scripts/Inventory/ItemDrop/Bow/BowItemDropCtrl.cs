using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowItemDropCtrl : ItemDropCtrl
{
    public override ItemCode GetItemCode()
    {
       return ItemCode.Bow;
    }
}
