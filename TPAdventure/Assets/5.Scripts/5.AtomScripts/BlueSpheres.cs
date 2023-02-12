using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpheres : MonoBehaviour
{
    float contador = 0f, x, y, z;

    void Update()
    {
        RotEsfera();
    }

    void RotEsfera()
    {
        contador += .11f;

        x = 0f;
        y = 100f * Mathf.Sin(contador * Mathf.PI / 180f);
        z = 100f * Mathf.Cos(contador * Mathf.PI / 180f);

        transform.position = new Vector3(x, y, z);

    }


}
