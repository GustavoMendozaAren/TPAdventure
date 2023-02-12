using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere45_2 : MonoBehaviour
{
    float rotation_speed;

    float contador = 0f, x, y, z;

    void Update()
    {
        contador += Time.deltaTime * .5f;

        x = 65 * (Mathf.Cos(contador + (Mathf.PI / 2f)));
        y = 0f;
        z = 65 * (Mathf.Sin(contador + (Mathf.PI / 2f)));

        transform.localPosition = new Vector3(x, y, z);
    }
}
