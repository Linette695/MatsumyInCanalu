using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelController : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverPanel;
    public GameObject player;
    public Timer timer;
    public Spheres spheres;
    //public PlayerHealth health;
    public HealthBar health;

    public PlayerInfo info;
    
    // Start is called before the first frame update
    void Start()
    {
        

        pauseMenu.SetActive(false);
        gameOverPanel.SetActive(false);

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
            spheres.spawnOn = false;
            timer.timerOn = false;
            timer.setTimeLeft(timer.getTimeLeft());
   
         /*   #if UNITY_EDITOR
             UnityEditor.EditorApplication.isPlaying = false;
            #else
              Application.Quit();
            #endif*/
        }

        //Check if it is GameOver 
        if (  health.healthBar.value == 0 ) {
            spheres.spawnOn = false;
            timer.timerOn = false;
            
            gameOverPanel.SetActive(true);
        }

        if (timer.timeLeft == 0) {
            info.setPlayerHealth(health.healthBar.value);
            switchScene(3);
        }

    }//End of Update 


    public void switchScene(int x)
    {
        Debug.Log("You've changed scnes to: " + x);
        SceneManager.LoadScene(x);
    }//End of switchScenes

}//End of GameLevelController class
