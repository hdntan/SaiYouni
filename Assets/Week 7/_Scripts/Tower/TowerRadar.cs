using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]

public class TowerRadar : MainBehaviourScript
{
    [SerializeField] protected EnemyCtrl nearest;
    [SerializeField] protected SphereCollider _collider;
    [SerializeField] protected Rigidbody _rigibody;
    [SerializeField] protected List<EnemyCtrl> enemies;







    protected virtual void FixedUpdate()
    {
        this.RemoveDeadEnemy();
        this.FindNearest();
    }

    protected virtual void OnTriggerEnter(Collider collider)     
    {
       
        EnemyCtrl enemy = collider.GetComponentInParent<EnemyCtrl>();
        if(enemy == null) return;

        this.AddEnemy(enemy);

       // Debug.Log(transform.name + " " + collider.name, gameObject);
    }

    protected virtual void OnTriggerExit(Collider collider)
    {

        EnemyCtrl enemy = collider.GetComponentInParent<EnemyCtrl>();
        if (enemy == null) return;

        this.RemoveEnemy(enemy);    

    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
        this.LoadRigibody();
    }

    protected virtual void LoadCollider()
    {
        if (_collider != null) return;
        this._collider = GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 12;
        Debug.Log(transform.name + ": LoadCollider", gameObject);
    }

    protected virtual void LoadRigibody()
    {
        if (_rigibody != null) return;
        this._rigibody = GetComponent<Rigidbody>();
        this._rigibody.useGravity = false;
      
        Debug.Log(transform.name + ": LoadRigibody", gameObject);
    }


    protected virtual void AddEnemy(EnemyCtrl enemy)
    {
        this.enemies.Add(enemy);
    }

    protected virtual void RemoveEnemy(EnemyCtrl enemy)
    {
        if(this.nearest == enemy) this.nearest = null;
        this.enemies.Remove(enemy);
    }

    protected virtual void FindNearest()
    {
        float nearestDistance = Mathf.Infinity;
        float enemyDistance;

        foreach (EnemyCtrl enemy in this.enemies)
        {

            enemyDistance = Vector3.Distance(enemy.transform.position, transform.position);
            if (enemyDistance < nearestDistance)
            {
                nearestDistance = enemyDistance;
                this.nearest = enemy;
            }
        }
    }

    public virtual EnemyCtrl GetTarget()
    {
        return this.nearest;
    }

    protected virtual void RemoveDeadEnemy()
    {
        foreach (EnemyCtrl enemyCtrl in this.enemies)
        {
            if (enemyCtrl.EnemyDamageReceiver.IsDead())
            {
                if (enemyCtrl == this.nearest) this.nearest = null;
                this.enemies.Remove(enemyCtrl);
                return;
            }
        }
    }
}
