using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DelegateSubscriber : MonoBehaviour, IExample
{
    private Material renderMaterial;

  //  public Transform transform; 
    // Start is called before the first frame update
    void Start()
    {
        SizeMultiplier = 1; 
        renderMaterial = GetComponent<MeshRenderer>().material; 
      //  transform = GetComponent<Transform>();          
        // single cast delegates
       // DelegateExample.ONChangeProperty = UpdateColor;

        // multicast delegates
      //  DelegateExample.ONChangeProperty += UpdateColor;
      //  DelegateExample.ONChangeProperty += UpdatePosition;
        MyContoller.OnClicked += UpdateColor; 
        MyContoller.OnClicked += UpdatePosition; 
    }

    public void UpdateColor()
    {
        renderMaterial.color = new Color(Random.Range(0F,1F), Random.Range(0, 1F), Random.Range(0, 1F)); 
    }

    public void UpdatePosition()
    {
        transform.position += new Vector3(0, Random.Range(-.2f, .2f), 0); 
    }



    private void OnDisable()
    {
           // unsubscribing delegates
           DelegateExample.ONChangeProperty -= UpdateColor;
           DelegateExample.ONChangeProperty -= UpdatePosition;
    }

    // interface stuff
    public float SizeMultiplier
    {
        get;
        private set; 
    }

    public void Shrink(float amount)
    {

        transform.localScale *= amount;  
    }
}
