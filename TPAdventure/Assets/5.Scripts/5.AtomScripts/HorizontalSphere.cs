using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSphere : MonoBehaviour
{
    float contador = 0f, x, y, z;

    private void Start()
    {
        transform.Rotate(0f, 0f, 45f);
    }

    void Update()
    {
        RotEsfera();
    }

    void RotEsfera()
    {
        contador += Time.deltaTime * .5f;

        x = 65 * Mathf.Cos(contador + (3.1416f/2f));
        y = 0f;
        z = 65 * Mathf.Sin(contador + (3.1416f / 2f));

        transform.position = new Vector3(x, y, z);

    }
}
