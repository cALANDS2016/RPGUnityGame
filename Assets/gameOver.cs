using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

    bool gameHasEnded = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            gameHasEnded = true;
        }
    }

    public bool getGameState()
    {
        return gameHasEnded;
    }
}
