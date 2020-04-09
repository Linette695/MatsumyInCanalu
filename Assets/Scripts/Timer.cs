using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60;      //To hold the time left (in seconds!)
    public bool timerOn = false; //flag to see if timer is running
    public Text timeText; //text variable to hold the time 




    // Start is called before the first frame update
    void Start()
    {
        //Start timer at the beginning
        timerOn = true;

    }//End of Start 

    // Update is called once per frame
    void Update()
    {

        if (timeLeft > 0 && timerOn)
        {
            timeLeft -= Time.deltaTime;
            displayTime(timeLeft);
        }
        else if (timerOn == false)
        {
            displayTime(timeLeft);
        }
        else
        {
            Debug.Log("You've survived!");
            timeLeft = 0;
            timerOn = false;
        }


    }//End of Update 

    public void displayTime(float t) {
        if (t == 0)
        {

            float mins = Mathf.FloorToInt(t / 60);  //Calculate the minutes
            float secs = Mathf.FloorToInt(t % 60);  //Calculate the seconds
            timeText.text = string.Format("{0:00}:{1:00}", mins, secs);
        }
        else
        {
            t += 1;

            float mins = Mathf.FloorToInt(t / 60);  //Calculate the minutes
            float secs = Mathf.FloorToInt(t % 60);  //Calculate the seconds


            timeText.text = string.Format("{0:00}:{1:00}", mins, secs);
        }
    }//End of displayTime

    public void setTimeLeft(float t) {
        timeLeft = t;
    }//end of setTimeLeft

    public float getTimeLeft() {
        return timeLeft;
    }//End of getTimeLeft

}//End of Timer class
