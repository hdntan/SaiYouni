using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : EnemyAbstract
{
    
    [SerializeField] protected PathMoving path;


    protected void FixedUpdate()
    {
        this.Moving();
    }



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPathMoving();
    }

    protected virtual void LoadPathMoving()
    {
        if(this.path != null) return;
        this.path = GameObject.Find("PathMoving").GetComponent<PathMoving>();   

    }

    protected virtual void Moving()
    {
        Point point = this.path.GetPoint(0);
        this.enemyCtrl.Agent.SetDestination(point.transform.position); 
    }
}
