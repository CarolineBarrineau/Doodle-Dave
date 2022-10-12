// The Jesters 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnTime;
    private Rigidbody2D pencil;
    public Transform pen;
    public float speed = 7f; // force
    
    public Vector3 leftEdge;
    public Vector3 rightEdge;
    public Vector2 direction = Vector2.right;
    public int size = 2;
    

    void Start()
    {
        pencil = GetComponent<Rigidbody2D>();
        this.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 1000000f);
        // leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        // rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);

    }

    // Update is called once per frame
    void Update()
    {
        // if position is past the right edge of the screen
        // if(direction.x > 0 && (pen.position.x - size) > rightEdge.x) {
        //     pen.position = new Vector3(leftEdge.x - size, pen.position.y, 0);
        // } else if(direction.x < 0 && (pen.position.x - size) < leftEdge.x) {
        //     pen.position = new Vector3(rightEdge.x - size, pen.position.y, 0);
        // } else {
        //     pen.Translate(direction * Time.deltaTime * Speed);
        // }
    }

}
