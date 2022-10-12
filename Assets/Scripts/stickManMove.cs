using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class stickManMove : MonoBehaviour
{
    public AudioSource ahhh;
    private Rigidbody2D rigidBody;
    public GameObject sceneManager;
    // public GameObject stickman;
    static public int TotalLives = 3;
    public int lives;
    Vector3 startPosition = Vector3.zero;

    // public AudioSource yippee;
    // start() is used for configurations
    void Start() {
        // initate where the stickman starts
        lives = TotalLives;
        startPosition = this.transform.position;
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    private void Move(Vector3 direction) {
        transform.position += direction;
    }
    
    // Update() is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
           Move(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
            Move(Vector3.down);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
           Move(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            Move(Vector3.left);
        }

    }
    // restart method
    void RestartPlayer() {
        // make his location go back to start
        sceneManager.SendMessage("RemoveLife");
        ahhh.Play(0);
        this.transform.position = startPosition;
        // prevents being affected by other forces when respawning
        rigidBody.velocity = Vector3.zero;
        lives--;
        if (lives <= 0) {
            //trigger GameOver
            SceneManager.LoadScene("LoseScene");
        }
    }
    void WinScene() {
        SceneManager.LoadScene("WinScene");
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Pencil") {
            // sceneManager.SendMessage("RemoveLife");
            RestartPlayer();
        }
        if (collision.gameObject.tag == "Eraser") {
            // sceneManager.SendMessage("RemoveLife");
            RestartPlayer();
        }
        if (collision.gameObject.tag == "sketchbook") {
            WinScene();
        }
            // yippee.Play(0);
            
    }
    
}
