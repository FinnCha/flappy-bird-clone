using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePreFab;
    [SerializeField] private float spawnDelay = 5;
    [SerializeField] public SpriteRenderer pipeSpriteRenderer;
    [SerializeField] public SpriteRenderer pipe2SpriteRenderer;
    private float nextSpawnTime;
    //private bool keyPressed;
    private float randomY;
    

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     Spawn();
        //     keyPressed = true;
        // }
        if (ShouldSpawn())
        {
            Spawn();
        }

    }

    void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        randomY = Random.Range(-0.72f, 4.1f);
        Instantiate(pipePreFab, new Vector2(0, randomY), transform.rotation);
        //keyPressed = false;
    }

    void ChangeColor()
    {
        if (Player.playerScore == 1)
        {
            pipeSpriteRenderer.color = Color.blue;
            pipe2SpriteRenderer.color = Color.blue;
        }
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
