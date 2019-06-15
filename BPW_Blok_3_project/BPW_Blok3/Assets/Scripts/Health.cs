using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealt;
    public int currentHealt;

    // Start is called before the first frame update
    void Start()
    {
        currentHealt = maxHealt;   
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void HurtPlayer(int damage){
        currentHealt -= damage;
    }

    public void HealtPlayer(int healAmount){
        currentHealt += healAmount;
        if(currentHealt > maxHealt){
            currentHealt = maxHealt;
        }
    }
}
