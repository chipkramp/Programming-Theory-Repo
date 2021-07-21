using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int lives;

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
