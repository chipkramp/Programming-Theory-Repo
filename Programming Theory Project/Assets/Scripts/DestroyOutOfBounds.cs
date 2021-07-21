using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xBound = 40.0f;

    void Update()
    {
        if (transform.position.x <= -xBound || transform.position.x >= xBound)
        {
            Destroy(gameObject);
        }
    }
}
