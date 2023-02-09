using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform LookAt;

    float contador = 0f, x, y, z;

    void Update()
    {
        transform.LookAt(LookAt);

        contador -= Time.deltaTime*.009f;

        x = 40 * Mathf.Cos(contador);
        y = 40 * Mathf.Sin(contador);
        z = 0f;

        transform.position = new Vector3(x, y, z);
    }
}
