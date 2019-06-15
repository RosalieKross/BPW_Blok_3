using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{

    public GameObject destroyEffect;
	private void OnCollisionEnter(Collision other)
	{
        if(other.gameObject.CompareTag("Player")){
            Instantiate(destroyEffect, transform.position, transform.rotation);

            Destroy(gameObject);

            Debug.Log("botsing");

        }
	}
}
