using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotMovment : MonoBehaviour
{
    float contador = 0f, x, y, z;
    void Update()
    {
        contador += Time.deltaTime;

        x = 15 * Mathf.Cos(contador);
        y = 0f;
        z = 15 * Mathf.Sin(contador);

        transform.position = new Vector3(x, y, z);
    }
}
