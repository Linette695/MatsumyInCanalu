using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelController : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverPanel;
    public GameObject nextLevelPanel;
    public GameObject player;
    public Timer timer;
    public Spheres spheres;
    public SpheresL spheresL;
    //public PlayerHealth health;
    public HealthBar health;

    public PlayerInfo info;
    
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
        //Check if player has quitted the game using the escape key
        if (Input.GetKeyDown(KeyCode.Escape)){
            pauseMenu.SetActive(true);
            timer.timerOn = false;
            spheres.spawnOn = false;
            spheresL.spawnOn = false;
            timer.setTimeLeft(timer.getTimeLeft());
   
        
        }

        //Check if it is GameOver  due to no more health
        if (  health.healthBar.value == 0 ) {
            spheres.spawnOn = false;
            spheresL.spawnOn = false;
            timer.timerOn = false;
            
            gameOverPanel.SetActive(true);
        }


        //Check if player survived the level due to surviving the countdown
        if (timer.timeLeft == 0) {
            spheres.spawnOn = false;
            spheresL.spawnOn = false;
            timer.timerOn = false; 

            info.setPlayerHealth(health.healthBar.value);
            Debug.Log("You've survived!");
            Debug.Log("health is:" + info.getPlayerHealth());
            Debug.Log("umbrellas is:" + info.getNumUbrellas());

            nextLevelPanel.SetActive(true);
        }

    }//End of Update 


    public void switchScene(int x)
    {
        Debug.Log("You've changed scnes to: " + x);
        SceneManager.LoadScene(x);
    }//End of switchScenes

}//End of GameLevelController class
