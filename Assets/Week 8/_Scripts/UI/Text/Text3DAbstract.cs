using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public abstract class Text3DAbstract : MainBehaviourScript
{
    [SerializeField] protected TextMeshPro textPro;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTextPro();
    }

    protected virtual void LoadTextPro()
    {
        if (this.textPro != null) return;
        this.textPro = GetComponent<TextMeshPro>();
        Debug.Log(transform.name + ": LoadTextPro", gameObject);
    }
}
