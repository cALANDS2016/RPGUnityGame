using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollision : MonoBehaviour {

    bool gameHasEnded = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "skell")
        {
            gameHasEnded = true;
        }
    }

    public bool getGameState()
    {
        return gameHasEnded;
    }
}
