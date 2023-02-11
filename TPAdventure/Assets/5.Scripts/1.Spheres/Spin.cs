using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    //public GameObject Sun;

    float contador = 0f, x, y, z;

    void Update()
    {
        transform.Rotate(new Vector3(0.008f, 0f, 0f));

        contador += Time.deltaTime * .002f;

        x = 0f;
        y = 200f * Mathf.Sin(contador);
        z = 200f * Mathf.Cos(contador);

        transform.position = new Vector3(x, y, z);
    }
}
