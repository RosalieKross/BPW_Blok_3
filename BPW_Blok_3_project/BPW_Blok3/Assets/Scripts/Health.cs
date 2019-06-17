using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float startHealth;
    public float currentHealth;
    public PlayerMovement thePlayer;
    public Image healthbar;

    private bool isRespawning;
    private Vector3 respawningPoint;

    public float respawnLegnth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;

        respawningPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void HurtPlayer(int damage){
        currentHealth -= damage;

        healthbar.fillAmount = currentHealth / startHealth;

        if(currentHealth <= 0){
            Debug.Log("Game Over");
            Respawn();

        }
    }

    public void Respawn()
    {
        Debug.Log("Gespawned");
        thePlayer.transform.position = respawningPoint;
        healthbar.fillAmount = startHealth;
        currentHealth = startHealth;
       // if (!isRespawning)
       // {
       //     StartCoroutine("RespawnCo");
       // }
    }

   // public IEnumerator RespawnCo(){
   //     isRespawning = true;
   //     yield return new WaitForSeconds(respawnLegnth);
   //     isRespawning = false;
        
    //}

    public void HealtPlayer(int healAmount){
        currentHealth += healAmount;
        if(currentHealth > startHealth){
            currentHealth = startHealth;
        }
    }
}
