using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSphere : MonoBehaviour
{
    float contador = 0f, x, y, z;

    void Update()
    {
        RotEsfera();
    }

    void RotEsfera()
    {
        contador += .11f;

        x = 100f * Mathf.Cos((contador * Mathf.PI / 180f) + (Mathf.PI / 2f));
        y = 0f;
        z = 100f * Mathf.Sin((contador * Mathf.PI / 180f) + (Mathf.PI / 2f));

        transform.position = new Vector3(x, y, z);

    }
}
