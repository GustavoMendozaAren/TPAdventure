using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere45 : MonoBehaviour
{
    float rotation_speed;

    //float contador = 0f, x, y, z, z2;
     
    void Update()
    {

        rotation_speed += Time.deltaTime * 10;
        /*contador += Time.deltaTime;

        x = 65 * -(Mathf.Cos(contador + (3.1416f / 4f)));
        y = 0f;
        z = 65 * (Mathf.Sin(contador + (3.1416f / 4f)));

        transform.position = new Vector3(x, y, z);*/
    }

}
