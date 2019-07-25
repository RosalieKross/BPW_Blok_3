using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    Health playerHealt;

    public float healthBonus = 15f;

    void Awake()
    {
        playerHealt = FindObjectOfType<Health>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerHealt.currentHealth < playerHealt.startHealth)
        {
     
            Destroy(gameObject);
            playerHealt.currentHealth = playerHealt.currentHealth + healthBonus;
            
        }
    }

}
