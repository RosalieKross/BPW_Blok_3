using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    public GameObject spawnEffect;
   // private bool canSpawn = true;

    void OnTriggerEnter()
    {

        //if (canSpawn == true)
        //{
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        Instantiate(spawnEffect, Spawnpoint.position, Spawnpoint.rotation);
            //canSpawn = false;
        //}
    }

}
