using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float speed = 100f;
    Vector3 change;

    private void Start()
    {
        
    }

    //void Turning()
    //{
    //    RotateX = CrossPlatformInputManager.GetAxis("Mouse X");
    //    RotateY = CrossPlatformInputManager.GetAxis("Mouse Y");
    //    Vector3 relativePos = new Vector3(RotateX, 0, RotateY);
    //    newPos += relativePos;
    //    newPos = newPos.normalized * Time.deltaTime;
    //    Quaternion rotation = Quaternion.LookRotation(newPos);
    //    playerRigidbody.MoveRotation(rotation);
    //}

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0).normalized * Time.deltaTime * speed);
        }

    }
}
