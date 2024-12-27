using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingRightHandHint : MainBehaviourScript
{

    //Vector3(0.694999993,-0.194999993,-0.0939999968)
    //Vector3(351.606079,339.907257,2.84678173)

    protected override void Reset()
    {
        this.LoadComponents();
        this.ResetValue();
    }

    //protected virtual void ResetValue()
    //{
    //    transform.localPosition = new Vector3(0.695f, -0.195f, 0.094f);
    //    transform.localRotation = Quaternion.Euler(351.606079f, 339.907257f, 2.84678173f);
    //}

    protected virtual void ResetValue()
    {
        transform.localPosition = new Vector3(0.338f, -0.0299999993f, 0.245000005f);
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
}
