using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAction : MonoBehaviour
{
    int layerMask = 1 << 8;
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (cam != null)
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100))
                {

                    IExample shrinkable = hit.transform.GetComponent<IExample>();
                    if (shrinkable != null)
                    {
                        shrinkable.Shrink(.5f);

                        Debug.Log(hit.transform.GetComponent<IExample>().SizeMultiplier.ToString());
                        Debug.Log(hit.transform.name);
                        Debug.Log("hit");
                    }

                }
            }
        }

    }
}
