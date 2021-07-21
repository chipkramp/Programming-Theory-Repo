using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MainManager : MonoBehaviour
{
    public static bool isGameOver;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text livesText;

    // ENCAPSULATION
    private static int livesInput;
    public static int lives
    {
        get { return livesInput; }
        set
        {
            if (value > 5)
            {
                Debug.Log("Value should be less than 6");
                livesInput = 5;
            }
            else
                livesInput = value;
        }
    }

    void Awake()
    {
        lives = GameManager.lives;
        isGameOver = false;
        livesText.text = livesText.text = "Lives: " + lives;
    }

    void Update()
    {
        if (isGameOver)
        {
            DestroyEntities();
            gameOverScreen.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(1);
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                Destroy(GameObject.Find("Game Manager"));
                SceneManager.LoadScene(0);
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            isGameOver = true;
        }
    }

    void DestroyEntities()
    {
        var objectsToDestroy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var item in objectsToDestroy)
        {
            Destroy(item);
        }
    }

    public void LivesUpdate()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        if (lives == 0)
        {
            isGameOver = true;
        }
    }
}
