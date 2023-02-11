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
        contador += Time.deltaTime * .5f;

        x = 0f;
        y = 65 * Mathf.Sin(contador);
        z = 65 * Mathf.Cos(contador);

        transform.position = new Vector3(x, y, z);

    }


}
