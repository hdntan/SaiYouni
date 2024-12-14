using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CapsuleCollider))]
public class EnemyDamageReceiver : DamgeReceiver
{
    [SerializeField] protected EnemyCtrl ctrl;
    [SerializeField] protected CapsuleCollider capsuleCollider;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
        this.LoadCapsuleCollider();
    }

    protected virtual void LoadEnemyCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = GetComponentInParent<EnemyCtrl>();
        Debug.Log(transform.name + ": LoadEnemyCtrl", gameObject);
    }

    protected virtual void LoadCapsuleCollider()
    {
        if(this.capsuleCollider != null) return;    
        this.capsuleCollider = GetComponentInParent<CapsuleCollider>();
        this.capsuleCollider.center = new Vector3(0,1,0);
        this.capsuleCollider.radius = 0.3f;
        this.capsuleCollider.height = 1.7f;
        this.capsuleCollider.isTrigger = true;


        Debug.Log(transform.name + ": LoadCapsuleCollider", gameObject);
    }
    protected override void OnDead()
    {
        this.ctrl.Animator.SetBool("isDead", this.isDead);
        this.capsuleCollider.enabled = false;

        Invoke(nameof(this.DoDespawn), 5f);
    }

    protected virtual void DoDespawn()
    {
        this.ctrl.Despawn.DoDespawn();

    }

    protected override void OnHurt()
    {
        
        this.ctrl.Animator.SetBool("isHit", true);

        Invoke(nameof(this.ResetHitAnimation), 0.5f);
    }


    protected override void Reborn()
    {
        base.Reborn();
        this.capsuleCollider.enabled = true;
    }

    public override void Receiver(int damage, DamgeSender damgeSender)
    {
        base.Receiver(damage, damgeSender);

    }

    public virtual void ResetHitAnimation()
    {
        this.ctrl.Animator.SetBool("isHit", false);
    }

}
