using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : EnemyAbstract
{
    
    [SerializeField] protected PathMoving path;
    [SerializeField] protected Point currentPoint;
    [SerializeField] protected int currentPointIndex = 0;
    [SerializeField] protected float pointDistance = Mathf.Infinity;
    [SerializeField] protected float pointDistanceLimit = 1f;
    [SerializeField] protected bool isMoving = false;
    [SerializeField] protected bool isFinish = false;




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
        this.LoadMovingStatus();

        if (this.isFinish || this.IsDead())
        {
            this.enemyCtrl.Agent.isStopped = true;
            return;
        }
        this.GetNextPoint();
        this.enemyCtrl.Agent.SetDestination(this.currentPoint.transform.position);
    }

    protected virtual void GetNextPoint()
    {
        this.currentPoint = this.path.GetPoint(this.currentPointIndex);
        this.pointDistance = Vector3.Distance(this.currentPoint.transform.position, transform.position);
        if (this.pointDistance < this.pointDistanceLimit) this.currentPointIndex++;
        if (this.currentPointIndex > this.path.Points.Count - 1) this.isFinish = true;
    }

    protected virtual void LoadMovingStatus()
    {
        this.isMoving = !this.enemyCtrl.Agent.isStopped;
        this.enemyCtrl.Animator.SetBool("isMoving",this.isMoving);
    }

    protected virtual bool IsDead()
    {
       return this.enemyCtrl.EnemyDamageReceiver.IsDead();
    }
}
