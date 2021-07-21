using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMoving : MonoBehaviour
{
    protected MainManager mainManager;

    void Awake()
    {
        mainManager = GameObject.Find("Main Manager").GetComponent<MainManager>();
    }

    public void MovingForward(float speed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    // POLYMORPHISM
    public void MovingForward(float speed, bool flag)
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
    }
}
