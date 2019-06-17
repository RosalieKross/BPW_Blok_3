using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverEndOfWorld : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<Health>().Respawn();
        }
    }
}
