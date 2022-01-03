using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IExample 
{
    float SizeMultiplier {get;} 
    void Shrink(float amount); 
}
