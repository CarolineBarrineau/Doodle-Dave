using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserCollision : MonoBehaviour
{
    GameObject eraser;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(7, 3);
        
        GameObject border = GameObject.FindGameObjectWithTag("Wall");
        eraser = GameObject.FindGameObjectWithTag("Eraser");
        
        Collider2D thisCollider = GetComponent<Collider2D>();
        Collider2D[] borderColliders = border.GetComponents<Collider2D>();
        
        foreach (Collider2D c in borderColliders)
            Physics2D.IgnoreCollision(thisCollider, c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // runs into player, send message to restart player
        if (collision.gameObject.tag == "Destroyer") {
            // pen.SendMessage("RestartPlayer");
            // ADD SOME NOISE HERE
            Destroy(this.gameObject);
        }
    }

}
