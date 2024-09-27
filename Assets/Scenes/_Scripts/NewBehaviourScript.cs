using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int maxInt = int.MaxValue;
    float maxFloat = float.MaxValue;
    double maxDouble = double.MaxValue;

  
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Max int: {this.maxInt}");
        Debug.Log($"Max float: {this.maxFloat}");
        Debug.Log($"Max double: {this.maxDouble}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
