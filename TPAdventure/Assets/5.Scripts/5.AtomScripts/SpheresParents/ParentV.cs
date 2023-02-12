using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentV : MonoBehaviour
{
    float contador = 0f, x, y, z;
    void Update()
    {
        x = 0f;
        y = 0f;
        z = .11f / 2f;

        transform.Rotate(x, y, z, Space.World);

    }
}
