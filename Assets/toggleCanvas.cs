using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleCanvas : MonoBehaviour {

    CanvasGroup canvasGroup;
    [SerializeField] Text text;
    [SerializeField] GameObject gameOverBox;
    [SerializeField] GameObject player;
    

	// Use this for initialization
	void Start () {
        canvasGroup = this.GetComponent<CanvasGroup>();
	}
	
	// Update is called once per frame
	void Update () {

        if(gameOverBox.GetComponent<gameOver>().getGameState())
        {
            text.text = "You Win";
            text.fontSize = 40;
            StartCoroutine(FadeCanvas(0f, 1f, 1f));
        }
        else if(player.GetComponent<DeathCollision>().getGameState())
        {
            text.text = "You Lose";
            text.fontSize = 40;
            StartCoroutine(FadeCanvas(0f, 1f, .1f));
        }
        else 
        {
            StartCoroutine(FadeCanvas(1f, 0f, 10f));
        }
    }

    private IEnumerator FadeCanvas(float iniAlpha, float finalAlpha, float time)
    {
        float elapsedTime = 0f;
        while (elapsedTime <= time)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(iniAlpha, finalAlpha, elapsedTime / time);
            yield return null;
        }
        canvasGroup.alpha = finalAlpha;
    }

}
