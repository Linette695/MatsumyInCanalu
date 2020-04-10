using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo 
{

    float playerValue;
    int numUmbrellas;
    
    // Start is called before the first frame update

    public PlayerInfo() {
        playerValue = 0;
        numUmbrellas = 0;
    }

    public void setPlayerHealth(float h) {
        playerValue = h;
    }

    public float getPlayerHealth() {
        return playerValue;
    }

    public void setNumUmbrellas(int x) {
        numUmbrellas = x;
    }

    public int getNumUbrellas() {
        return numUmbrellas;
    }
}//End of PlayerInfo
