using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public abstract class DamgeSender : MainBehaviourScript
{
    [SerializeField] protected int damge = 1;
    [SerializeField] protected Rigidbody _rigibody;
    [SerializeField] protected Collider _collider;


 

    protected virtual void OnTriggerEnter(Collider collider)
    {
       this.SendDamage(collider);
    }

    protected virtual DamgeReceiver SendDamage(Collider collider)
    {

        Debug.LogError(transform.parent.name + " ==> " + collider.transform.parent.name);
        DamgeReceiver dameReceiver = collider.GetComponent<DamgeReceiver>();
        if (dameReceiver == null) return null;

        dameReceiver.Receiver(this.damge, this);
        Debug.Log(transform.name + ": " + collider.name, gameObject);
        return dameReceiver;
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigibody();
        this.LoadTriggerCollider();
    }

    protected virtual void LoadRigibody()
    {
        if (this._rigibody != null) return;
        this._rigibody = GetComponent<Rigidbody>();
        this._rigibody.useGravity = false;
        Debug.Log(transform.name + ": LoadRigibody", gameObject);

    }



    protected virtual void LoadTriggerCollider()
    {
        if (this._collider != null) return;
         this._collider = GetComponent<Collider>();
        this._collider.isTrigger = true;
        Debug.Log(transform.name + ": LoadCollider", gameObject);
    }




}
