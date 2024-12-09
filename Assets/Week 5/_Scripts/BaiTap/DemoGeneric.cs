using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoGeneric : MonoBehaviour
{
    
    void Start()
    {
        //Bài tập 1
        GenericScript<int> intContainer = new GenericScript<int>(42);
        intContainer.PrintData(); 

        GenericScript<float> floatContainer = new GenericScript<float>(3.14f);
        floatContainer.PrintData(); 

        GenericScript<string> stringContainer = new GenericScript<string>("Hello Unity");
        stringContainer.PrintData(); 

        // Bài tập 2
        int[] intArray = { 1, 5, 3, 9, 2 };
        Debug.Log("Max int: " + GenericScript<int>.FindMax(intArray)); 

        
        float[] floatArray = { 1.2f, 3.4f, 0.5f, 2.8f };
        Debug.Log("Max float: " + GenericScript<float>.FindMax(floatArray));


        string[] stringArray = { "apple", "orange", "banana", "pear" };
        Debug.Log("Max string: " + GenericScript<string>.FindMax(stringArray));

        // *Bài tập 3
        int x = 5, y = 10;
        Debug.Log($"Trước khi hoán đổi: x = {x}, y = {y}");
        GenericScript<int>.Swap(ref x, ref y);
        Debug.Log($"Sau khi hoán đổi: x = {x}, y = {y}");




        // Bài tập 4
        GenericListManager<string> stringManager = new GenericListManager<string>();
        stringManager.AddItem("Apple");
        stringManager.AddItem("Banana");
        stringManager.AddItem("Cherry");
        stringManager.PrintAllItems();
        stringManager.RemoveItem("Banana");
        stringManager.PrintAllItems();

       
        stringManager.ClearAllItems();
        stringManager.PrintAllItems();



        //Bài tập 5

        Debug.Log(GenericScript<int>.Contains(intArray, 3) ? "3 tồn tại trong mảng." : "3 không tồn tại trong mảng.");
        Debug.Log(GenericScript<int>.Contains(intArray, 6) ? "6 tồn tại trong mảng." : "6 không tồn tại trong mảng.");

       


    }


}
