using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : EntityMoving
{
    [SerializeField] float speed = 0;

    void Update()
    {
        // INHERITANCE
        MovingForward(speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            mainManager.LivesUpdate();
            Destroy(gameObject);
        }
    }
}
