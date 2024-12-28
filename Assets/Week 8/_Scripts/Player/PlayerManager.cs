using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MainBehaviourScript
{
    [SerializeField] protected bool isActive = true;
    public bool IsActive => isActive;
    [SerializeField] protected PlayerInput playerInput;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerInput();
    }

    protected virtual void LateUpdate()
    {
        this.EnableActivePlayerInput();
    }


    protected virtual void LoadPlayerInput()
    {
        if (this.playerInput != null) return;
        this.playerInput = transform.GetComponentInChildren<PlayerInput>();
        Debug.Log(transform.name + " LoadPlayerInpyt: ", gameObject);
    }


    public virtual void Show()
    {
        this.isActive = true;
        this.playerInput.enabled = this.isActive;
    }

    public virtual void Hide()
    {
        this.playerInput.enabled = false;
        this.isActive = false;
    }


    protected virtual void EnableActivePlayerInput()
    {
        if (UIInventory.Instance.IsShow || UIShop.Instance.IsShow) this.Hide();

        else this.Show();
    }
        
}
