using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingRightHandTarget : MainBehaviourScript
{
   

    protected override void Reset()
    {
        this.LoadComponents();
        this.ResetValue();
    }

    //protected virtual void ResetValue()
    //{
    //    transform.localPosition = new Vector3(0.0920000002f, 0.180999994f, 0.395999998f);
    //    transform.localRotation = Quaternion.Euler(2.81969762f, 264.585358f, 311.642029f);
    //}

    protected virtual void ResetValue()
    {
        transform.localPosition = new Vector3(0.209000006f, 0.0759999976f, 0.298999995f);
        transform.localRotation = Quaternion.Euler(new Vector3(9.53907776f, 271.061768f, 268.303101f));
    }
}

