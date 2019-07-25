using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public ParticleSystem flash;
    public GameObject impacteffect;
    public float impactForce = 30f;
    public Camera fpsCam;
    private AudioSource mAudioSrc;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Shoot();
        }

        mAudioSrc = GetComponent<AudioSource>();

    }

    void Shoot()
    {
        mAudioSrc.Play();
        flash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null){
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null){
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGone = Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGone, 2f);
        }

    }
}
