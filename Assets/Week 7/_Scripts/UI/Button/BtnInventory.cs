using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnInventory : ButtonAbstract
{
    public override void OnClick()
    {
        UIInventory.Instance.Toggle();
    }
}
