using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTest : MonoBehaviour
{

    float velocidad = 0f, j = -1f, i = -20f;

    void Update()
    {
            
        transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * 12.5f));

        if (i < -2f)
        {
            i += Time.deltaTime * ;
        }
        else
        {
            i = -2f;
        }
        if (velocidad >= -220f)
        {
            velocidad -= Time.deltaTime * 11.25f;
        }
        if (velocidad < -220f)
        {
            j = j - .01f;
            velocidad += ((Time.deltaTime * 11.25f) / j);
        }
        if (j < -20f)
        {
            j = -20f;
        }
        if (velocidad < -280f)
        {
            velocidad = -280f;
        }

        transform.position = new Vector3(0f, 0f, -55f + velocidad);


    }
}
