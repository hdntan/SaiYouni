using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHotkeys : MainSingleton<InputHotkeys>
{
    protected bool isToogleInventoryUI = false;

    public bool IsToogleInventoryUI => isToogleInventoryUI;

    protected bool isToogleShopUI = false;

    public bool IsToogleShopUI => isToogleShopUI;



    protected bool isToogleMusic = false;
    public bool IsToogleMusic => isToogleMusic;

    protected bool isToogleSetting = false;
    public bool IsToogleSetting => isToogleSetting;


    protected virtual void Update()
    {
        this.OpenInventory();
        this.ToogleMusic();
        this.ToogleSetting();
        this.OpenShop();
    }

    protected virtual void OpenInventory()
    {
        this.isToogleInventoryUI = Input.GetKeyUp(KeyCode.I);
    }

    protected virtual void OpenShop()
    {
        this.isToogleShopUI = Input.GetKeyUp(KeyCode.S);
    }

    protected virtual void ToogleMusic()
    {
        this.isToogleMusic = Input.GetKeyUp(KeyCode.M);
    }

    protected virtual void ToogleSetting()
    {
        this.isToogleSetting = Input.GetKeyUp(KeyCode.N);
    }
}
