using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float MAX_TIME = 60;
    float currTime;
    public TMP_Text lblTime;

    // public int livesRemaining = 2;
    // public TMP_Text lblLives;

    public AudioSource penClick;
    public GameObject gameManager;

    void Start()
    {
        currTime = MAX_TIME;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        penClick.PlayDelayed(50.0f);
    }

    // Update is called once per frame
    void Update()
    {
        currTime -= Time.deltaTime;
        lblTime.text = ((int)currTime).ToString();

        // if(currTime <= 10.0f)
        //     lblTime.color = Color.red;

        if (currTime <= 0.0f)
            gameManager.SendMessage("GotoGameOver");
    }

    // void RemoveLife() {
    //     this.livesRemaining--;
    // }
}
