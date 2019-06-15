using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    //public Color welkeKleur;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Material OldColor;
    public Material NewColor;

	void OnTriggerEnter(Collider other)
	{
        Renderer render = GetComponent<Renderer>();
        render.material = NewColor;//welkeKleur;
	}

    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material = OldColor;//welkeKleur;
    }
}
