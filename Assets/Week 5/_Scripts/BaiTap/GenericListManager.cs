using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericListManager<T> 
{
    
    private List<T> items = new();

    public void AddItem(T item)
    {
        this.items.Add(item);
        Debug.Log($"Đã thêm: {item}");
    }

    public bool RemoveItem(T item)
    {
        if (this.items.Remove(item))
        {
            Debug.Log($"Đã xóa: {item}");
            return true;
        }
        else
        {
            Debug.LogWarning($"Không tìm thấy: {item}");
            return false;
        }
    }


    public void PrintAllItems()
    {
        Debug.Log("Danh sách các mục:");
        foreach (T item in this.items)
        {
            Debug.Log(item);
        }
    }


    public void ClearAllItems()
    {
        this.items.Clear();
        Debug.Log("Đã xóa toàn bộ danh sách.");
    }
}
