using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelController : MonoBehaviour
{
    public GameObject pauseMenu;        //Pause Menu Panel
    public GameObject gameOverPanel;    //Game Over Panel
    public GameObject nextLevelPanel;   //Next Level Panel

    public GameObject player;   //The player/character

    public Timer timer;     //Timer

    public HealthBar health; //HealthBar


    public PlayerInfo info;     //Singleton Item to hold the players items

    //Objects to spawn
    public Spheres spheres;
    public SpheresL spheresL;
    public PurpleRain purpleRaindrops;
    public BlueRain blueRaindrops;

    
    

    
    // Start is called before the first frame update
    void Start()
    {
        
        //Make panels not visible at beginning
        pauseMenu.SetActive(false);
        gameOverPanel.SetActive(false);
        nextLevelPanel.SetActive(false);

        //Initiate the Singleton object/the player info
        info = Singleton.Instance.info;
        Debug.Log("health is:" + info.getPlayerHealth());
        Debug.Log("umbrellas is:" + info.getNumUbrellas());
    }



    // Update is called once per frame
    void Update()
    {
        //CHECK IF PAUSE MENU HAS BEEN CALLED USING ESC KEY
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Display the pause Menu
            pauseMenu.SetActive(true);  

            //Turn off timer
            timer.timerOn = false;

            //Stop the spawning of items
            spheres.spawnOn = false;
            spheresL.spawnOn = false;
            purpleRaindrops.spawnOn = false;
            blueRaindrops.spawnOn = false;

            //Display and update frozen time
            timer.setTimeLeft(timer.getTimeLeft());

/*
            //This is to apply when colliding with Mushroom
            player.transform.localScale = new Vector2(1.4f, 1.4f);
            player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.6f, 0);*/

        }


        //CHECK IF HEALTH IS 0, IF SO END GAME
        if (  health.healthBar.value == 0 ) {
            //Stop the spawning of items
            spheres.spawnOn = false;
            spheresL.spawnOn = false;
            purpleRaindrops.spawnOn = false;
            blueRaindrops.spawnOn = false;

            //Stop timer
            timer.timerOn = false;
            
            //Display Game Over Panel
            gameOverPanel.SetActive(true);
        }


        //CHECK IF COUNTDOWN IS OVER, IF SO DISPLAY NEXT LEVEL PANEL
        if (timer.timeLeft == 0) {
            //Stop the spawning of items
            spheres.spawnOn = false;
            spheresL.spawnOn = false;
            purpleRaindrops.spawnOn = false;
            blueRaindrops.spawnOn = false;

            //Stop timer
            timer.timerOn = false; 

            //Update the singleton object
            info.setPlayerHealth(health.healthBar.value);
            Debug.Log("You've survived!");
            Debug.Log("health is:" + info.getPlayerHealth());
            Debug.Log("umbrellas is:" + info.getNumUbrellas());

            //Display the next level panel
            nextLevelPanel.SetActive(true);
        }

    }//End of Update 

    /*switchScene meethod switches the scene to the corresponding scene coded with int given*/
    public void switchScene(int x)
    {
        Debug.Log("You've changed scnes to: " + x);
        SceneManager.LoadScene(x);
    }//End of switchScenes

}//End of GameLevelController class
