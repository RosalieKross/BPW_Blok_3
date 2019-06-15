using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    private bool canSpawn = true;

    void OnTriggerEnter()
    {

        if (canSpawn == true)
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            canSpawn = false;
        }
    }

}
