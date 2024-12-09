using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbstract : MainBehaviourScript
{

    [SerializeField] protected EnemyCtrl enemyCtrl;
    


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCrtl();
    }


    protected virtual void LoadEnemyCrtl()
    {
        if (enemyCtrl != null) return;
        this.enemyCtrl = GetComponentInParent<EnemyCtrl>();

    }

}
