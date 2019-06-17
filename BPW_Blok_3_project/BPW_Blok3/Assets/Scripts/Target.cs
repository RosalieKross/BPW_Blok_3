using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float startHealth = 50f;
    public GameObject destroyEffect;
    public float currentHealt;

    private float health;

    public Image healthbar;


	private void Start()
	{
        currentHealt = health;
        health = startHealth;
	}

	public void TakeDamage (float amount){
        health -= amount;

        healthbar.fillAmount = health / startHealth;
        currentHealt = health;
        if(health <= 0f){
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
        Instantiate(destroyEffect, transform.position, transform.rotation);
    }
}
