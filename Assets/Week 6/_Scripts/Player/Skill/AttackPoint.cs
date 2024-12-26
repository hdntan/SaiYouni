using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPOint : MainBehaviourScript
{
    protected override void Reset()
    {
        base.Reset();
        transform.localPosition = new Vector3(-0.297f, 0.15f, -0.0301f);
    }
}
