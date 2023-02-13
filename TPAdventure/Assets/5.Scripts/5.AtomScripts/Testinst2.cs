using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testinst2 : MonoBehaviour
{
    float x, y, z, contador = 0f;
    void Update()
    {
        /*contador += Time.deltaTime * 90f;

        x = 10 * Mathf.Cos((contador * Mathf.PI) / 180f);
        y = 0f;
        z = 10  *Mathf.Sin((contador * Mathf.PI) / 180f);*/

        

        transform.position = new Vector3(x, y, z);
    }
}
