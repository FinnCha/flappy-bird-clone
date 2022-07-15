using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private bool mousekeyPressed;
    public static int playerScore = 1;
    public GameOverScreen GameOverScreen;
    [SerializeField] public Text scoreText;
    [SerializeField] public Text gameOverScoreText;
    [SerializeField] public Transform playerTransform;
    [SerializeField] public GameObject levelText;
    //[SerializeField] public SpriteRenderer pipeSpriteRenderer;
    //[SerializeField] public SpriteRenderer pipe2SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        levelText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            mousekeyPressed = true;
            playerTransform.rotation = Quaternion.Euler(0,0,-105);
        }
        if (playerScore == 25) {
            StartCoroutine(ShowAndHide(1.0f));
        }
    }
    //https://answers.unity.com/questions/1238052/how-do-make-an-object-appear-and-disappear-after-t.html
    IEnumerator ShowAndHide(float delay)
    {
        levelText.SetActive(true);
        yield return new WaitForSeconds(delay);
        levelText.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (mousekeyPressed)
        {
            playerRB.velocity = new Vector2(0, 4.0f);
            mousekeyPressed = false;
            playerTransform.rotation = Quaternion.Euler(0,0,-90);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 6) //score trigger layer
        {
            scoreText.text = playerScore++.ToString(); //score trigger collider
            //Debug.Log(playerScore);
        }

        if (other.gameObject.layer == 3 ) //pipe collider layer
        {
            playerRB.gravityScale = 9; //idk whats up with the gravity scales
            Debug.Log("Ded");
            GameOverScreen.Setup();
            gameOverScoreText.text = playerScore.ToString(); 
            playerScore = 1;
        }
        

    }
}
