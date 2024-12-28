using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolCtrl : MainBehaviourScript
{
    [SerializeField] protected Transform model;
    //Vector3(-0.0399999991,0.123999998,0.0270000007)
    //Vector3(86.6822357,131.311462,220.706848)
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        this.model.localPosition = new Vector3(-0.0399999991f, 0.123999998f, 0.0270000007f);
        this.model.localRotation = Quaternion.Euler(new Vector3(86.6822357f, 131.311462f, 220.706848f));
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }
}
