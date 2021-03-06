using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject pauseMenu;    //The pause menu
    public Timer timer;     //Timer

    //Spawining objects
    public Spheres spheres;
    public SpheresL spheresL;
    public PurpleRain purpleRainDrops;
    public BlueRain blueRainDrops;

   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }//End of Update


    public void switchScenes(int x)
    {
        Debug.Log("You've changed scnes to: " + x);
        SceneManager.LoadScene(x);
    }//End of switchScenes

    public void end()
    {
        Debug.Log("You've clicked the quit button! ");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif


    }//End of End


    public void howToPlay() {
        Debug.Log("Use arrow keys");

        //Make sure the button does not look like it has been clicked
        EventSystem.current.SetSelectedGameObject(null);
    }//End of howToPlay

    public void unpause() {

        //Make the pause menu go away
        pauseMenu.SetActive(false);
        Debug.Log("Curr Scene: " + SceneManager.GetActiveScene().name);

        //Turn ob spawning of objects according to which level player is in
        if (SceneManager.GetActiveScene().name.Equals("Level 1"))
        {
            //Turn on the spawn of rocks 
            spheres.spawnOn = true;
            spheresL.spawnOn = false;
            

        }
        else if (SceneManager.GetActiveScene().name.Equals("Level3")) {
            //Turn on the spawn of the rocks and rain
            spheres.spawnOn = true;
            spheresL.spawnOn = true;
            purpleRainDrops.spawnOn = true;
            blueRainDrops.spawnOn = true;
        }
        else
        {
            //Turn on the spawn of the rocks
            spheres.spawnOn = true;
            spheresL.spawnOn = true;
        }

        //Turn on the timemer 
        timer.setTimeLeft(timer.getTimeLeft());
        timer.timerOn = true;
        
    }//End of unpause




}//End of Buttons class
