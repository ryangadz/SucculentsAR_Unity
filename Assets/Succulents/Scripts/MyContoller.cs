using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyContoller : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void ClickAction(); 
    public static event ClickAction OnClicked; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (OnClicked != null)
                OnClicked(); 
        }
 
    }
}
