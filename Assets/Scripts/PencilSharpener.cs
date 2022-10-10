using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilSharpener : MonoBehaviour
{
    public AudioSource pencilSharpener;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(6,7);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player"){
            pencilSharpener.Play(0);
            Destroy(this.gameObject);
        }
    }
}
