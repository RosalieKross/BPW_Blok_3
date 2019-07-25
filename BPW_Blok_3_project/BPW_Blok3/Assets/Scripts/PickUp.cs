using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	public int HealthBonus = 2;
   
    public AudioClip AudioClip; //Audio clip
    public AudioSource pickUpSource; // Game object waar het geluid vanaf moet komen

    // Start is called before the first frame update
    void Start()
	{
        pickUpSource.clip = AudioClip;
    }

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			FindObjectOfType<Health>().PickUp(HealthBonus);
            pickUpSource.Play();
            Destroy(gameObject, 0.2f);
        }
            }
}
