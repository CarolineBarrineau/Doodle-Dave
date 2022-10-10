using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilSpawner : MonoBehaviour
{
    public float spawnTime;
    public float speed;
    public GameObject pencil;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(50);
        speed = Random.Range(3,5);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime >= 0.0f) {
            spawnTime -= Time.deltaTime;
            return;
        }
        spawnTime = 3.2f;

        Vector3 location = Vector3.zero;
        location.x = transform.position.x;
        location.y = transform.position.y;

        GameObject newPencil = Instantiate(pencil, location, Quaternion.identity);
        newPencil.GetComponent<Rigidbody2D>().AddForce(Vector3.right*1000000f);
    }
}
