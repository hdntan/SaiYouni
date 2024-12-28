using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnItemWand : ButtonAbstract
{
    [SerializeField] protected TextMeshProUGUI txtItemName;
    [SerializeField] protected TextMeshProUGUI txtItemCount;
    [SerializeField] protected RawImage ItemImage;


    [SerializeField] protected ItemInventory itemInventory;


    public ItemInventory ItemInventory => itemInventory;

    protected virtual void FixedUpdate()
    {
        this.ItemUpdating();
    }

    public override void OnClick()
    {
        //TODO: open item detail
        //UIItemDetail.Instance.Open(item);
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemName();
        this.LoadItemCount();
        this.LoadItemImage();
    }

    protected virtual void LoadItemName()
    {
        if (this.txtItemName != null) return;
        this.txtItemName = transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
        Debug.Log(transform.name + ": LoadTexts", gameObject);
    }

    protected virtual void LoadItemCount()
    {
        if (this.txtItemCount != null) return;
        this.txtItemCount = transform.Find("ItemCount").GetComponent<TextMeshProUGUI>();
        Debug.Log(transform.name + ": LoadTexts", gameObject);
    }

    protected virtual void LoadItemImage()
    {
        if (this.ItemImage != null) return;
        this.ItemImage = transform.Find("ItemImage").GetComponent<RawImage>();
        Debug.Log(transform.name + ": LoadTexts", gameObject);
    }

    public virtual void SetItem(ItemInventory itemInventory)
    {
        this.itemInventory = itemInventory;
    }


    protected virtual void ItemUpdating()
    {
        this.txtItemName.text = this.itemInventory.GetItemName();
        this.txtItemCount.text = this.itemInventory.itemCount.ToString();
        this.ItemImage.texture = this.itemInventory.ItemProfile.itemTexture;

        if (this.itemInventory.itemCount == 0) Destroy(gameObject);
    }
}
