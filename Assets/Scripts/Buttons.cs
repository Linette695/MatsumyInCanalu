using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject pauseMenu;
    public Timer timer;
    public Spheres spheres;
    public SpheresL spheresL;
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
        
        //Turn on the spawn of the spheres 
        spheres.spawnOn = true;
        spheresL.spawnOn = true;

        //Turn on the timemer 
        timer.setTimeLeft(timer.getTimeLeft());
        timer.timerOn = true;
        
    }//End of unpause




}//End of Buttons class
