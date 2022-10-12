using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserBehavior : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 100000f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
