using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRandom : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Slider slider;
    public int maxHealth = 0;
    public int minHealth = 100;
    //----------------------Edit above here --------------------
    public void Start()
    {
        slider.minValue = minHealth;
        slider.maxValue = maxHealth;
    }

    // On Click function
    public void OnClick()
    {
        RandomHealth();
    }

    //----------------------Edit below here --------------------
    public int RandomHealth()
    {
        int newHp = Random.Range(this.minHealth, this.maxHealth + 1);
       return newHp;
    }
}
