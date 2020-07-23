using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject ball;
    public GameObject camera;
    // Update is called once per frame
    void Update()
    {
        camera.transform.position = ball.transform.position + new Vector3(-17, 19, 14);     
    }
}
