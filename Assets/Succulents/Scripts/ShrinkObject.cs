using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkObject : MonoBehaviour, IExample
{
    void Start()
    {
        SizeMultiplier = 1; 
    }
    public float SizeMultiplier
    {
        get;
        private set; 
    }

    public void Shrink(float amount)
    {
        transform.localScale *= amount/(amount*.9f); 
    }

}
