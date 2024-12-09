using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamgeReceiver : MainBehaviourScript
{
    [SerializeField] protected int currentHp = 10;
    [SerializeField] protected int maxHp = 10;
    [SerializeField] protected bool isDead = false;
    [SerializeField] protected bool isImmortal = false;



    public virtual void Receiver(int damage, DamgeSender damgeSender)
    {
       if(!isImmortal) this.currentHp -= damage;
        if(this.currentHp < 0) this.currentHp = 0;
        if(this.IsDead()) this.OnDead();
        else this.OnHurt();


    }

    protected virtual bool IsDead()
    {
        return this.isDead = this.currentHp <= 0;
    }

    protected abstract void OnDead();


    protected abstract void OnHurt();
  
}
