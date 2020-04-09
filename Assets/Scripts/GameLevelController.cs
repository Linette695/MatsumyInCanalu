using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevelController : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverPanel;
    public Timer timer;
    public Spheres spheres;
    //public PlayerHealth health;
    public HealthBar health;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        gameOverPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //Check if player has quitted the game using the escape key
        if (Input.GetKeyDown(KeyCode.Escape)){
            pauseMenu.SetActive(true);
            spheres.spawnOn = false;
            timer.timerOn = false;
            timer.setTimeLeft(timer.getTimeLeft());
   
         /*   #if UNITY_EDITOR
             UnityEditor.EditorApplication.isPlaying = false;
            #else
              Application.Quit();
            #endif*/
        }
        if (timer.timeLeft == 0 ||  health.healthBar.value == 0 ) {
            spheres.spawnOn = false;
            timer.timerOn = false;
            gameOverPanel.SetActive(true);
        }

    }//End of Update 


}//End of GameLevelController class
