using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandBasicCtrl : MainBehaviourScript
{
    [SerializeField] protected Transform model;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        this.model.localPosition = new Vector3(-0.0170000009f, 0.0839999989f, 0.0160000008f);
        this.model.localRotation = Quaternion.Euler(new Vector3(3.59961224f, 347.83493f, 81.1833344f));
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }
}
