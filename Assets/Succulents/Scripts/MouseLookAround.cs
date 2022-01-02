using UnityEngine;
 
public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;
 
    public float sensitivity = 15f;
 
    private bool isMouseDown = false; 
    void Update()
    {
        if (!isMouseDown && Input.GetMouseButtonDown(1))
            isMouseDown = true; 
        else if (isMouseDown && Input.GetMouseButtonUp(1))
            isMouseDown = false; 

        if(isMouseDown)
        {
            rotationY += Input.GetAxis("Mouse X") * sensitivity;
            rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
            transform.localEulerAngles = new Vector3(rotationX,rotationY,0);
        }




    }
}