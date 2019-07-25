using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive = 1;
    public AudioClip AudioClip; //Audio clip
    public AudioSource SoundSource; // Game object waar het geluid vanaf moet komen

    // Start is called before the first frame update
    void Start()
    {
        SoundSource.clip = AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        if(other.gameObject.tag == "Player"){
            FindObjectOfType<Health>().HurtPlayer(damageToGive);
            SoundSource.Play();
        }
	}
}
