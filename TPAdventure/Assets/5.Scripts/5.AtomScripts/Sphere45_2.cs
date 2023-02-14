using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere45_2 : MonoBehaviour
{
    float rotation_speed;

    float contador = 0f, x, y, z;

    void FixedUpdate()
    {
        contador += Time.deltaTime * 36f;

        x = 0f;
        y = 100f * Mathf.Cos((contador * Mathf.PI / 180f) + (Mathf.PI / 2f));
        z = 100f * Mathf.Sin((contador * Mathf.PI / 180f) + (Mathf.PI / 2f));

        transform.localPosition = new Vector3(x, y, z);

    }
}
