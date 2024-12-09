using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolObj : MainBehaviourScript
{
    [SerializeField] protected DespawnBase desspawn;

    public DespawnBase Despawn => desspawn;

    public abstract string GetName();

    protected override void LoadComponents()
    {
        base.LoadComponents();
    }

    protected virtual void LoadDespawn()
    {
        if (this.desspawn != null) return;
        this.desspawn = transform.GetComponentInChildren<DespawnBase>();
        Debug.Log(transform.name + ": LoadDespawn", gameObject);
    }
}
