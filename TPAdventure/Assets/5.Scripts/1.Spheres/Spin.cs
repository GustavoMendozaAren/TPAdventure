using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    //public GameObject Sun;

    float contador = 0f, x, y, z;

    void Update()
    {
        transform.Rotate(new Vector3(0f, 0.015f, 0f));

        contador += Time.deltaTime * .005f;

        x = 60f * Mathf.Cos((3.1416f / 4f) + contador);
        y = 0f;
        z = 60f * Mathf.Sin((3.1416f / 4f) + contador);

        transform.position = new Vector3(x, y, z);
    }
}
