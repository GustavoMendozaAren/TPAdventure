using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    float contador = 0f, x, y, z;

    public GameObject sphere;

    void Update()
    {
        contador += Time.deltaTime*.05f;

        x = 20 * Mathf.Cos(contador);
        y = 20 * Mathf.Sin(contador);
        z = 0f;

        transform.position = new Vector3(sphere.transform.position.x + x, sphere.transform.position.y + y, sphere.transform.position.z + z);
    }
}
