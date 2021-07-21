using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    private float speed = 30.0f;
    private float yRange = 13.0f;

    void Update()
    {
        if (!MainManager.isGameOver)
        {
            float verticalInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.up * Time.deltaTime * verticalInput * speed, Space.World);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // ABSTRACTION
                TakeShot();
            }
            // ABSTRACTION
            BoundCheck();
        }
    }

    void TakeShot()
    {
        Vector3 projectilePos = new Vector3(projectilePrefab.transform.position.x, gameObject.transform.position.y - 0.4f, projectilePrefab.transform.position.z);
        Instantiate(projectilePrefab, projectilePos, projectilePrefab.transform.rotation);
    }

    void BoundCheck()
    {
        if (transform.position.y >= 13)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        if (transform.position.y <= -13)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
    }
}
