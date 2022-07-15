using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroyer : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Destroy(collision.gameObject);
    //     Debug.Log("destroyed");
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(this);
    }
}

