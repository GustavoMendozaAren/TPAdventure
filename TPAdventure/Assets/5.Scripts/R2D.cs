using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2D : MonoBehaviour
{
    float contador = 0f, x, y, z;
    void Update()
    {
        contador += 0.5f;
        print(contador);

        x = 10 * Mathf.Cos(contador * Mathf.PI / 180f);
        y = 0f;
        z = 10 * Mathf.Sin(contador * Mathf.PI / 180f);

        transform.position = new Vector3(x, y, z);

        
    }
}
