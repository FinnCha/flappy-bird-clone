using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pipes : MonoBehaviour
{
    [SerializeField] private Rigidbody2D scoreTriggerRB;
    
    //[SerializeField] private GameObject pipe1, pipe2;
    private Rigidbody2D rb;
    private float xVelocity;
    int _playerScore = Player.playerScore;

    
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        xVelocity = -5f;
    }

    // Update is called once per frame
    void Update()
    {
        //pipe1.transform.position = new Vector2(0, 2f);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(xVelocity, 0);
        scoreTriggerRB.velocity = new Vector2(xVelocity, 0);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 8)
        {
            Destroy(this.gameObject);
            Destroy(this); //destroys the script, wont have score trigger freaking out then
        }

    }
}
