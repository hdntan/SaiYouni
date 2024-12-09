using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDameReceiver : DamgeReceiver
{
    protected override void OnDead()
    {
        Destroy(transform.parent.gameObject);
    }

    protected override void OnHurt()
    {
        // new System.NotImplementedException();
    }
}
