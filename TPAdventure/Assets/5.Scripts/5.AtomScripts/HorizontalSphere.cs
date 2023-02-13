using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSphere : MonoBehaviour
{
    float contador = 0f, x, y, z;

    void Update()
    {
        RotEsfera();
    }

    void RotEsfera()
    {
        contador += Time.deltaTime * 60f;

        x = 0f;
        y = 100f * Mathf.Cos((contador * Mathf.PI / 180f) + (Mathf.PI / 2f));
        z = 100f * Mathf.Sin((contador * Mathf.PI / 180f) + (Mathf.PI / 2f));

        transform.localPosition = new Vector3(x, y, z);

    }
}
