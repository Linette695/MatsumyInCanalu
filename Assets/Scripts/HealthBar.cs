using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public PlayerHealth playerHealth;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

        playerHealth = player.GetComponent<PlayerHealth>(); //Obtain the player health
        healthBar = GetComponent<Slider>(); //Obtain the slider
        healthBar.maxValue = playerHealth.maxHealth;    //Set the max value of healthBar 
        healthBar.value = playerHealth.maxHealth;   //Set the default value of the healthBar

    }//End of start

    // Update is called once per frame
    public void setHealth(int h) {
        healthBar.value = h;
    
    }//End of setHealth
}
