
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : MainBehaviourScript
{
    [SerializeField] protected NavMeshAgent agent;
    public NavMeshAgent Agent => agent;

    [SerializeField] protected Animator animator;
    public Animator Abimator => animator;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAgent();
      
    }

    protected virtual void LoadAgent()
    {
        if (this.agent != null) return;

        this.agent = GetComponent<NavMeshAgent>();

        Debug.Log(transform.name + ":LoadAgent", gameObject);


    }

    

}
