using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserSpawner : MonoBehaviour
{
    public float spawnTime = 3f;
    public float speed;
    public float currSpeed;
    public GameObject eraser;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (spawnTime >= 0.0f) {
            spawnTime -= Time.deltaTime;
            return;
        }
        spawnTime = 3.0f;

        Vector3 location = Vector3.zero;
        location.x = transform.position.x;
        location.y = transform.position.y;

        GameObject newEraser = Instantiate(eraser, location, Quaternion.identity);
        newEraser.GetComponent<Rigidbody2D>().AddForce(Vector3.left*100000f);
    }
}
