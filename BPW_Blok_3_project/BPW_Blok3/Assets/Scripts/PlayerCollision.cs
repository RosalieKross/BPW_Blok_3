using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    //public PlayerMovement movement;   // speler kan niet meer bewegen
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle"){
           
            Debug.Log("We hebben iets geraakt");
            //movement.enabled = false;     // speler kan niet meer bewegen
    }

        if (collisionInfo.collider.tag == "Poep")
        {

            Debug.Log("We zijn ergens in getrapt");

        }

   }
}