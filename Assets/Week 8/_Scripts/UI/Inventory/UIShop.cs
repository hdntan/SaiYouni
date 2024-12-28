using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShop : MainSingleton<UIShop>
{
    [SerializeField] protected bool isShow = true;
    public bool IsShow => isShow;

    [SerializeField] protected Transform showHide;

    [SerializeField] protected BtnItemInventory defaultItemInventoryUI;
    [SerializeField] protected List<BtnItemInventory> btnItems = new();
    [SerializeField] protected List<ItemProfileSO> itemProfiles;
    [SerializeField] protected List<ItemInventory> items = new();
    public List<ItemInventory> Items => items;

    protected virtual void FixedUpdate()
    {
    }

    protected virtual void LateUpdate() 
    {
        this.HotkeyToogleInventory();
    }

    protected override void Start()
    {
        base.Start();
        this.Hide();
        this.CreateItems();

    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemProfiles();

        this.LoadShowHide();
        this.LoadBtnItemInventory();
        this.ItemsUpdating();



    }

    protected virtual void LoadItemProfiles()
    {
        if (this.itemProfiles.Count > 0) return;
        ItemProfileSO[] itemProfileSOs = Resources.LoadAll<ItemProfileSO>("/");
        this.itemProfiles = new List<ItemProfileSO>(itemProfileSOs);
        Debug.Log(transform.name + ": LoadItemProfiles", gameObject);
    }


    protected virtual void LoadShowHide()
    {
        if (this.showHide != null) return;
        this.showHide = transform.Find("ShowHide");
        Debug.Log(transform.name + ": LoadShowHide", gameObject);
    }

    protected virtual void LoadBtnItemInventory()
    {
        if (this.defaultItemInventoryUI != null) return;
        this.defaultItemInventoryUI = GetComponentInChildren<BtnItemInventory>();
        Debug.Log(transform.name + ": LoadBtnItemInventory", gameObject);
    }

    public virtual void Show()
    {
        this.isShow = true;
        this.showHide.gameObject.SetActive(this.isShow);
    }

    public virtual void Hide()
    {
        this.showHide.gameObject.SetActive(false);
        this.isShow = false;
    }

    public virtual void Toggle()
    {
        if (this.isShow) this.Hide();
        else this.Show();
    }

    protected virtual void HideDefaultItemInventory()
    {
        this.defaultItemInventoryUI.gameObject.SetActive(false);
    }

    protected virtual void ItemsUpdating()
    {
      
        BtnItemInventory newBtnItem;
        foreach (ItemInventory itemInventory in Items)
        {
            newBtnItem = this.GetExistItem(itemInventory);
            if (newBtnItem == null)
            {
                newBtnItem = Instantiate(this.defaultItemInventoryUI);
                newBtnItem.transform.SetParent(this.defaultItemInventoryUI.transform.parent);
                newBtnItem.SetItem(itemInventory);
                newBtnItem.transform.localScale = new Vector3(1, 1, 1);
                newBtnItem.gameObject.SetActive(true);
                newBtnItem.name = itemInventory.GetItemName() + "-" + itemInventory.ItemID;
                this.btnItems.Add(newBtnItem);
            }
        }
    }
    public virtual ItemInventory FindItem(ItemCode itemCode)
    {
        foreach (ItemInventory itemInventory in this.items)
        {
            if (itemInventory.ItemProfile.itemCode == itemCode) return itemInventory;
        }

        return null;
    }


    public virtual void CreateItems()
    {
        
            this.AddItem(ItemCode.ShortGun, 1);
        this.AddItem(ItemCode.Wand, 1);


    }

    public virtual void AddItem(ItemInventory item)
    {
        ItemInventory itemExist = this.FindItem(item.ItemProfile.itemCode);
        if (!item.ItemProfile.isStackable || itemExist == null)
        {
            item.SetId(Random.Range(0, 999999999));
            this.items.Add(item);
            return;
        }

        itemExist.itemCount += item.itemCount;
    }





    public virtual void AddItem(ItemCode itemCode, int itemCount)
    {
        ItemProfileSO itemProfile = this.GetProfileByCode(itemCode);
        ItemInventory item = new(itemProfile, itemCount);
        this.AddItem(item);
    }

    public virtual ItemProfileSO GetProfileByCode(ItemCode itemCodeName)
    {
        foreach (ItemProfileSO itemProfile in this.itemProfiles)
        {
            if (itemProfile.itemCode == itemCodeName) return itemProfile;
        }

        return null;
    }


    protected virtual BtnItemInventory GetExistItem(ItemInventory itemInventory)
    {
        foreach (BtnItemInventory itemInvUI in this.btnItems)
        {
            if (itemInvUI.ItemInventory.ItemID == itemInventory.ItemID) return itemInvUI;
        }
        return null;
    }

    protected virtual void HotkeyToogleInventory()
    {
        if (InputHotkeys.Instance.IsToogleInventoryUI) this.Toggle();
    }
}
