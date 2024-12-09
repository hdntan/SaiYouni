using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SphereCollider))]

public class BulletDameSender : DamgeSender
{

    [SerializeField] protected SphereCollider sphareCollider;
    [SerializeField] protected EffectDespawn despawn;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEffectDespawn();
    }

    protected virtual void LoadEffectDespawn()
    {
        if (this.despawn != null) return;
        this.despawn = transform.GetComponentInChildren<EffectDespawn>();
        Debug.Log(transform.name + ": LoadDespawn", gameObject);
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
        this.despawn.DoDespawn();
        return damgeReceiver;
    }
}
