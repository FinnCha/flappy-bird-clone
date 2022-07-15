using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup() //https://www.youtube.com/watch?v=K4uOjb5p3Io
    {
        gameObject.SetActive(true);
    }

    public void Restart()
    {
        Debug.Log("Loading scene..");
        SceneManager.LoadScene("sampleScene");
    }
}
