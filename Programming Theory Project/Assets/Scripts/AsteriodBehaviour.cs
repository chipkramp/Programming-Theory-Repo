using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodBehaviour : EntityMoving
{
    [SerializeField] float speed = 0;
    private Rigidbody asteriodRb;

    void Start()
    {
        asteriodRb = gameObject.GetComponent<Rigidbody>();
        // ABSTRACTION
        asteriodRb.AddTorque(RandomGen(), RandomGen(), RandomGen(), ForceMode.Impulse);
    }

    void Update()
    {
        // INHERITANCE
        MovingForward(speed, true);
    }

    public float RandomGen()
    {
        float num = 10;

        return Random.Range(-num, num);
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
