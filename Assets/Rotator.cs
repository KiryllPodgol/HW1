using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 1f;
    private bool isRotating = false;

 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRotating = !isRotating;
        }

        if (isRotating)
        {
            transform.Rotate(0.5f * speed, 1f * speed, 0.5f * speed);
        }
    }
}
