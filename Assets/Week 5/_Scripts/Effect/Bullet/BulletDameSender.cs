using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SphereCollider))]

public class BulletDameSender : DamgeSender
{

    [SerializeField] protected SphereCollider sphareCollider;
    [SerializeField] protected BulletCtrl ctrl;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBulletCtrl();
    }

   

    protected virtual void LoadBulletCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = transform.GetComponentInParent<BulletCtrl>();
        Debug.Log(transform.name + ": LoadBulletCtrl", gameObject);
    }

    protected override void LoadTriggerCollider()
    {
        if (this._collider != null) return;
        this._collider = GetComponent<Collider>();
        this._collider.isTrigger = true;
        this.sphareCollider = (SphereCollider)this._collider;
        this.sphareCollider.radius = 0.3f;

        Debug.Log(transform.name + ": LoadCollider", gameObject);
    }

    protected override DamgeReceiver SendDamage(Collider collider)
    {
        DamgeReceiver damgeReceiver =  base.SendDamage(collider);
        if (damgeReceiver == null) return null;
        this.ctrl.Despawn.DoDespawn();
        return damgeReceiver;
    }
}
