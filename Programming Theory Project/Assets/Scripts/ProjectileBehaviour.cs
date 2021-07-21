using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : EntityMoving
{
    [SerializeField] float speed = 0;

    void Update()
    {
        speed++;
        // INHERITANCE
        MovingForward(speed);
    }
}
