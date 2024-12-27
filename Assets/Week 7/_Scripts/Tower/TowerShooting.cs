using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : TowerAbstract
{
    [SerializeField] protected EnemyCtrl target;

    [SerializeField] protected EffectCode bulletCode = EffectCode.Projectile1;
    [SerializeField] protected EffectCode hitCode = EffectCode.Hit1;




    [SerializeField] protected float timer = 0;
    [SerializeField] protected float delay = 1f;
    [SerializeField] protected int firePointIndex = 0;

    [SerializeField] protected List<FirePoint> firePoints = new();


    [SerializeField] protected int killCount = 0;
    public int KillCount => killCount;

    [SerializeField] protected int totalKill = 0;



    protected virtual void FixedUpdate()
    {
        this.GetTarget();
        this.LookAtTarget();
        this.Shooting();
        this.IsTargetDead();
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFirePoints();
    }

    protected virtual void LoadFirePoints()
    {
        if (this.firePoints.Count > 0) return;
        FirePoint[] points = this.towerCtrl.GetComponentsInChildren<FirePoint>();
        this.firePoints = new List<FirePoint>(points);

        Debug.LogWarning(transform.name + ": LoadFirePoints", gameObject);
    }

    protected virtual void GetTarget()
    {
        this.target = this.towerCtrl.Radar.GetTarget();
    }

    protected virtual void LookAtTarget()
    {
        if (this.target == null) return;   
        this.towerCtrl.Rotator.LookAt(this.target.transform.position);
     
        

    }

    protected virtual void Shooting()
    {

        this.timer += Time.fixedDeltaTime;

        if (this.target == null) return;

        if (this.timer < this.delay) return;
        this.timer = 0;

        FirePoint firePoint = this.GetFirePoint();
        this.SpawnBullet(firePoint); 
        this.SpawnHIt(firePoint);
    }


    protected virtual EffectCtrl SpawnBullet(FirePoint firePoint)
    {
        EffectCtrl bulletPrefab = EffectSpawnerCtrl.Instance.Prefabs.GetByName(this.bulletCode.ToString());
        EffectCtrl newEffect = EffectSpawnerCtrl.Instance.Spawner.Spawn(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
        newEffect.gameObject.SetActive(true);

        return bulletPrefab;
    }


    protected virtual EffectCtrl SpawnHIt(FirePoint firePoint)
    {
        EffectCtrl hitPrefab = EffectSpawnerCtrl.Instance.Prefabs.GetByName(this.hitCode.ToString());
        EffectCtrl newEffect = EffectSpawnerCtrl.Instance.Spawner.Spawn(hitPrefab, firePoint.transform.position, firePoint.transform.rotation);
        newEffect.gameObject.SetActive(true);
        return hitPrefab;
    }


    protected virtual FirePoint GetFirePoint()
    {
        //int pointIndex = Random.Range(0,this.firePoints.Count);
        this.firePointIndex++;
        if(this.firePointIndex >= this.firePoints.Count) this.firePointIndex = 0;
        return this.firePoints[this.firePointIndex];
    }

    protected virtual bool IsTargetDead()
    {
        if (this.target == null) return true;
        if (!this.target.EnemyDamageReceiver.IsDead()) return false;
        this.killCount++;
        this.totalKill++;
        this.target = null;
        return true;
    }

    public virtual bool DeductKillCount(int count)
    {
        if (this.killCount < count) return false;
        this.killCount -= count; 
        return true;
    }
}
