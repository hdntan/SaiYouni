using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : EnemyAbstract
{


    [SerializeField] protected PathMoving path;
    [SerializeField] protected Point currentPoint;
    [SerializeField] protected int currentPointIndex = 0;
    [SerializeField] protected float pointDistance = Mathf.Infinity;
    [SerializeField] protected float pointDistanceLimit = 1f;
    [SerializeField] protected bool isFinish = false;
    [SerializeField] protected bool isMoving = false;



    void FixedUpdate()
    {
        this.Moving();
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPaths();

    }


    protected virtual void LoadPaths()
    {
        if (this.path != null) return;
        this.path = GameObject.Find("PathMoving_1").GetComponent<PathMoving>();
        Debug.Log(transform.name + ":LoadPaths", gameObject);
    }

    protected virtual void Moving()
    {

      
        if (this.isFinish)
        {
            this.ctrl.Agent.isStopped = true;
            return;
        }
        this.GetNextPoint();

        this.ctrl.Agent.SetDestination(this.currentPoint.transform.position);
    }

    protected virtual void GetNextPoint()
    {
        this.currentPoint = this.path.GetPoint(currentPointIndex);
        this.pointDistance = Vector3.Distance(this.currentPoint.transform.position, transform.position);
        if (this.pointDistance < this.pointDistanceLimit)
        {
            this.currentPointIndex++;
        }

        if (this.currentPointIndex > this.path.Points.Count - 1)
        {
            this.isFinish = true;
        }

    }

   
}
