using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolItemDropCtrl : ItemDropCtrl
{
    public override ItemCode GetItemCode()
    {
       return ItemCode.Pistol;
    }
}
