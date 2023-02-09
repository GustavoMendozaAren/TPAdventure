using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    float contador = 0f, x, y, z;

    void Update()
    {
        contador += Time.deltaTime * 0.02f;

        x = 10 * Mathf.Cos(contador);
        y = 10 * Mathf.Sin(contador);
        z = 0f;

        transform.position = new Vector3(x, y, z);
    }

        

}
