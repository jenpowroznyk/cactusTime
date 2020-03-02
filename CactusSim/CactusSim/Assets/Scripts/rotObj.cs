using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    public float rotSpeed;
    

    void Start()
    {
        

    }

   /* void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
       // float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
       // transform.Rotate(Vector3.right, rotY);

    }*/

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.up * rotSpeed * Time.deltaTime);

    }
}
