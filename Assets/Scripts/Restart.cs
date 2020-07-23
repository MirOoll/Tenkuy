using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject player;
    Rigidbody rb;
    public GameObject startPoint;

    public void Start()
    {
         rb = player.GetComponent<Rigidbody>();
    }

    public void restart()
    {
        player.gameObject.transform.position = startPoint.gameObject.transform.position;
        rb.velocity = new Vector3(0f, 0f, 0f);        
    }
}
