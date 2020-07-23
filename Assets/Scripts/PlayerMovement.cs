using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Teleport")
        {
            player.transform.position = new Vector3(10f, 10f, 25f);
        }
    }

}
