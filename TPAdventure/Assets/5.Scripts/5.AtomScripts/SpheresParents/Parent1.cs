using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent1 : MonoBehaviour
{
    float contador = 0f, x, y, z;
    void FixedUpdate()
    {
        x = 0f;
        y = 0f;
        z = Time.deltaTime * 9f;

        transform.Rotate(x, y, z, Space.World);
    }
}
