using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour 
{

    public Rigidbody rb;

    public int currentH = 0; //Wil hold the current health of the player
    public int maxHealth = 100; //The maximum health player can have
    public HealthBar healthBar;
    // Start is called before the first frame update

    void Start()
    {
        currentH = maxHealth;   //Set the default health
    }//End of Start




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            damageHealth(5);
        }

    }//End of Update

    public void damageHealth(int damage) {
        if (currentH - damage < 0)
        {
            currentH = 0; 
        }
        else
        {
            currentH -= damage;  
        }
        healthBar.setHealth(currentH);  //Update the health bar
    }//End of updateHEalth


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Sphere"))
        {
            
            damageHealth(10);
            Debug.Log("Character has touched sphere PLYER");
        }

    }//End of OnCollision2D

}//End of PlayerHealth class

