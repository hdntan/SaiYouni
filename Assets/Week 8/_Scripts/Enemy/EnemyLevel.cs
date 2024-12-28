using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevel : LevelAbstract
{

    [SerializeField] protected EnemyCtrl ctrl;
    [SerializeField] private float xpGainRate = 10f; 
    private float xpGainTimer = 0f; 
    private int currentExp = 0;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }

    protected virtual void LoadEnemyCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = GetComponentInParent<EnemyCtrl>();
        Debug.Log(transform.name + ": LoadEnemyCtrl", gameObject);
    }

    protected override bool DeductExp(int exp)
    {
        if (this.currentExp >= exp)
        {
            this.currentExp -= exp; 
            return true;
        }
        return false;
    }

    protected override int GetCurrentExp()
    {
       
        this.xpGainTimer += Time.deltaTime;

     
        if (this.xpGainTimer >= 1f)
        {
            int xpToAdd = Mathf.FloorToInt(this.xpGainTimer * this.xpGainRate); 
            this.xpGainTimer -= Mathf.Floor(this.xpGainTimer); 
            this.currentExp += xpToAdd; 

            Debug.Log($"{transform.name} gained {xpToAdd} XP. Total XP: {this.currentExp}");
        }


        return this.currentExp;
    }
}
