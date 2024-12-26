using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortGunCtrl : MainBehaviourScript
{
    [SerializeField] protected Transform model;
    //Vector3(-0.0790000036,0.254999995,0.0209999997)
    //Vector3(87.611969,39.052845,128.754471)
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        this.model.localPosition = new Vector3(-0.0790000036f, 0.254999995f, 0.0209999997f);
        this.model.localRotation = Quaternion.Euler(new Vector3(87.611969f, 39.052845f, 128.754471f));
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }
}
