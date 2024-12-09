using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericScript<T>  where T : IComparable<T>
{
    
    private T data;

    
    public GenericScript(T initialData)
    {
        this.data = initialData;
    }


    public T GetData()
    {
        return this.data;
    }


    public void SetData(T newData)
    {
        this.data = newData;
    }

   
    public void PrintData()
    {
        Debug.Log($"Data: {this.data}");
    }


    public static T FindMax(T[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng.");
        }

     
        T max = array[0];

       
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        return max;
    }


    public static void Swap<U>(ref U a, ref U b)
    {
        U temp = a;
        a = b;
        b = temp;
    }


    public static bool Contains<U>(IEnumerable<U> collection, U item)
    {
        foreach (U element in collection)
        {
            if (EqualityComparer<U>.Default.Equals(element, item))
            {
                return true;
            }
        }
        return false;
    }
}
