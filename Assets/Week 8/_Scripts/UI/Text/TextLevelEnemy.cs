using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLevelEnemy : TxtLevel
{
    [SerializeField] protected EnemyCtrl ctrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTowerCtrl();
    }

    protected virtual void LoadTowerCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = GetComponentInParent<EnemyCtrl>();
        Debug.Log(transform.name + ": LoadTowerCtrl", gameObject);
    }

    protected override string GetLevel()
    {
        return this.ctrl.Level.CurrentLevel.ToString();
    }
}
