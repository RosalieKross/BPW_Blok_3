using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpheight = 10.0f;
    public bool onGround;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, jumpheight, 0f);
                onGround = false;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            onGround = true;
        }
    }

}
