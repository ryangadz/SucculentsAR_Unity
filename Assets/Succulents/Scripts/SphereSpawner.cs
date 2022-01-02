using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public int num = 10; 
    public float radius = 1;  
    void Start()
    {
      if (prefab != null)
      {
          float angle =  (2 * 3.1416f) / (float)num; 
          for (int i = 0; i < num; i++)
          {
              Vector3 position = new Vector3(Mathf.Sin(angle * i) * radius, 
                                             0, 
                                             Mathf.Cos(angle * i) * radius); 
              Instantiate(prefab, position + transform.position, Quaternion.identity); 
          }
      }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
